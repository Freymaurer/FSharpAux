#### 1.1.0 - Monday, November 8, 2021

**FSharpAux**
* Add functions for:
  * Array:
    * filteri: Returns a new array containing only the elements of the input array for which the given predicate returns true.
    * countByPredicate: Returns the length of an array containing only the elements of the input array for which the given predicate returns true.
    * countiByPredicate: Returns the length of an array containing only the elements of the input array for which the given predicate returns true.
    * choosei: Applies the given function to each element of the array. Returns the array comprised of the results x for each element where the function returns Some x.
    * findIndices: Returns an array with the indeces of the elements in the input array that satisfy the given predicate.
    * findIndicesBack: Returns a reversed array with the indeces of the elements in the input array that satisfy the given predicate.
    * takeNth: Returns an array comprised of every nth element of the input array.
    * skipNth: Returns an array without every nth element of the input array.
  * JaggedArray:
    * toIndexedArray: Transforms a jagged array to an array where each position is indexed (first index: prior rows, second index: prior columns).
    * init: Creates a jagged array given the dimensions and a generator function to compute the elements.
  * Array2D:
    * rotate90DegClockwise: Rotates a 2D-array by 90° clockwise.
    * rotate90DegCounterClockwise: Rotates a 2D-array by 90° counter-clickwise.
    * rotate180Deg: Rotates a 2D-array by 180°.
    * flipHorizontally: Inverses the order of the rows of an 2D-array.
    * flipVertically: Inverses the order of the columns of an 2D-array.
    * toIndexedArray: Transforms a 2D-array to an array where each position is indexed (first index: prior rows, second index: prior columns).
  * List: 
    * filteri: Returns a new list containing only the elements of the list for which the given predicate returns true.
    * countByPredicate: Returns the length of a list containing only the elements of the input array for which the given predicate returns true.
    * countiByPredicate: Returns the length of a list containing only the elements of the input array for which the given predicate returns true.
    * choosei: Applies the given function to each element of the list. Returns the list comprised of the results x for each element where the function returns Some x.
    * findIndicesBack: Returns a reversed list with the indeces of the elements in the input array that satisfy the given predicate.
    * findIndices: Returns a list with the indices of the elements in the input array that satisfy the given predicate.
    * takeNth: Returns a list comprised of every nth element of the input list.
    * skipNth: Returns a list without every nth element of the input list.
  * JaggedList:
    * init: Creates a jagged list given the dimensions and a generator function to compute the elements.
  * Math:
    * nthRoot: Returns the nth root of x.
  * String:
    * first: Returns the first char of a string.
    * last: Returns the last char of a string.
    * splitS: Splits an input string at a given delimiter (substring).
    * findIndexBack: Returns the last index of a char in a string.
    * findIndex: Returns the first index of a char in a string.
    * findIndices: Returns the indices of a char in a string.
    * findIndicesBack: Returns the indices of a char in a string sorted backwards.
    * takeWhile: Iterates through the string and returns a string with the chars of the input until the predicate returned false the first time.
    * skipWhile: Iterates through the string and returns a string that starts at the char of the input where the predicate returned false the first time.

---

#### 1.0.0 - Thursday, February 13, 2019
First nuget release package.

**FSharpAux:**
 * Add symmetric difference function for Sets
 
**FSharpAux.IO**: no changes

---

#### 0.0.15 - Wednesday, October 2, 2019
* add an improved Seq to CSV formatter (Seq.CSV)
* mark the old CSV formatter as deprecated

---

#### 0.0.14 - Friday, August 30, 2019
* add colors to Color table
* fix shuffle functions
* update FSharp.Core to version 4.6.2

---

#### 0.0.13 - Tuesday, January 8, 2019
* add functions to Array Extensions

---

#### 0.0.12 - Monday, December 3, 2018
* Improve Csv reader

---

#### 0.0.11 - Sunday, November 4, 2018
* Improve Csv reader

---

#### 0.0.1 - Wednesday, August 8, 2018
* Initial release
