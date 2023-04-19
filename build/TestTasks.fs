﻿module TestTasks

open BlackFox.Fake
open Fake.DotNet

open ProjectInfo
open BasicTasks

open Fake.DotNet

let runTests = BuildTask.create "RunTests" [clean; build] {
    testProjects
    |> Seq.iter (fun testProject ->
        Fake.DotNet.DotNet.test(fun testParams ->
            {
                testParams with
                    Logger = Some "console;verbosity=detailed"
                    Configuration = DotNet.BuildConfiguration.fromString configuration
                    NoBuild = true
            }
        ) testProject
    )
}

let runTestsFable = BuildTask.create "runTestsFable" [clean; buildFable] {
    fableLibs
    |> Seq.iter (fun testProject ->
        Fake.DotNet.DotNet.test(fun testParams ->
            {
                testParams with
                    Logger = Some "console;verbosity=detailed"
                    Configuration = DotNet.BuildConfiguration.fromString configuration
                    NoBuild = true
            }
        ) testProject
    )
    //|> Seq.iter (fun testProject ->
    //    Fake.DotNet.DotNet.test(fun testParams ->
    //        let msBuildParams =
    //            {testParams.MSBuildParams with 
    //                Properties = ([
    //                    "DefineConstants", "FABLE_COMPILER"
    //                ] @ testParams.MSBuildParams.Properties)
    //            }
    //        {
    //            testParams with
    //                Logger = Some "console;verbosity=detailed"
    //                Configuration = DotNet.BuildConfiguration.fromString configuration
    //                NoBuild = true
    //                MSBuildParams = msBuildParams
    //        }
    //    ) testProject
    //)
}

module private FableHelper =

    open Fake.Core

    let createProcess exe arg dir =
        CreateProcess.fromRawCommandLine exe arg
        |> CreateProcess.withWorkingDirectory dir
        |> CreateProcess.ensureExitCode

    let npm =
        let npmPath =
            match ProcessUtils.tryFindFileOnPath "npm" with
            | Some path -> path
            | None ->
                "npm was not found in path. Please install it and make sure it's available from your path. " +
                "See https://safe-stack.github.io/docs/quickstart/#install-pre-requisites for more info"
                |> failwith

        createProcess npmPath

    let run proc arg dir =
        proc arg dir
        |> Proc.run
        |> ignore
    

let runTestsMocha = BuildTask.create "runTestsMocha" [clean; runTestsFable] {
    FableHelper.run FableHelper.npm "test" ""
}

//// to do: use this once we have actual tests
//let runTestsWithCodeCov = BuildTask.create "RunTestsWithCodeCov" [clean; build] {
//    let standardParams = Fake.DotNet.MSBuild.CliArguments.Create ()
//    testProjects
//    |> Seq.iter(fun testProject -> 
//        Fake.DotNet.DotNet.test(fun testParams ->
//            {
//                testParams with
//                    MSBuildParams = {
//                        standardParams with
//                            Properties = [
//                                "AltCover","true"
//                                "AltCoverCobertura","../../codeCov.xml"
//                                "AltCoverForce","true"
//                            ]
//                    };
//                    Logger = Some "console;verbosity=detailed"
//            }
//        ) testProject
//    )
//}
