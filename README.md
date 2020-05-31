
Practice Creating Classes in C#

1st Challenge
--------------------------------------------------

1. Add at least two classes to your program—one class for each type of item—or media type—that can be added to your media library.
  a) Define each class using the `class` keyword within its own C# code file. 
  b) Use "Treehouse.MediaLibrary" for the namespace.

2. Add at least two public fields to each media type class that you added in step #1.
  a) Each field definition should include an access modifier, a data type, and a name.

Media Type Examples

* Album media type, with `Title` and `Artist` fields
* Book media type, with `Title` and `Author` fields
* Movie media type, with `Title` and `Director` fields

2nd Challenge
--------------------------------------------------

1. In the Program.cs file `Main()` method, use the `new` keyword to create at least one instance of each of your media type classes.

2. For each of the objects that you create, set each field to an appropriate value.

3rd Challenge
--------------------------------------------------

1. Add a constructor to each of your media type classes.

2. Define a constructor parameter for each of the media type's required fields and use those parameter values to initialize its fields.

3. Update the Program.cs file `Main()` method in order for your program to successfully compile.

############################################################################################################################################
Practice Methods in C#

1st Challenge
--------------------------------------------------

1. Add a `GetDisplayText()` method to your selected media type class. This method should return a string containing the display text for the media type item.

Example: The `GetDisplayText()` method for an Album class would return the text "Album: Yellow Submarine by The Beatles" if the `Title` field was set to "Yellow Submarine" and the `Artist` field was set to "The Beatles".

2nd Challenge
--------------------------------------------------

1. Add a method named `Loan()` that accepts a string of the name of the person who is borrowing the item.
  a) Store the person's name in a new field named `Loanee`.
  b) Use a boolean field, `OnLoan`, to indicate whether or not an item has been loaned out.

2. Add a method named `Return()` that resets the loan related fields to their default values.
  a) `null` for the `Loanee` field and `false` for the `OnLoan` field.

3. Update the `GetDisplayText()` method to include the loan related fields if the item is on loan.
  a) For example, if an album is currently on loan, it should display the text "Album: Yellow Submarine by The Beatles (Currently on loan to Joe Smith)".

4. Test your changes by updating the Program.cs file `Main()` method to call the `Loan()` and `Return()` methods.

3rd Challenge
--------------------------------------------------

1. Add a method overload for the `Loan()` method that doesn't accept any parameters.

2. Update the `GetDisplayText()` method to account for when the `Loanee` field doesn't have a value.