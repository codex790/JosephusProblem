# JosephusProblem

Consider the following children's game.

* ***n*** children stand around a circle
* Starting with a given child and working clockwise, each child gets a sequential number, which we will refer to as it's id.
* Then starting with the first child, they count out from 1 until ***k***. The ***k'th*** child is now out and leaves the circle. The count starts again with the child immediately next to the eliminated one.
* Children are so removed from the circle one by one. The winner is the last child left standing.

- - - - 

Here is the code which, when given ***n*** and ***k***, returns:
* The sequence of children as they are eliminated, and
* The id of the winning child.


The aim is to use as littl memory as possible and runtime order complexity for the solution.

