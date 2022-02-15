
MSMG test - Diogo Marques

To open git repo
https://gitready.com/intermediate/2009/01/24/sharing-your-changes.html
"
Probably the easiest way to quickly export and share your code in this case is by making a bare clone of your repository, which contains only the stuff in the .git directory that’s usually at your project’s root folder. Since this one folder has all of the history stored in it, you can easily extract anything you need from it. Simply do:

git clone --bare ~/Dev/ruby/jekyll jekyll.git

and then upload the folder to a server somewhere, share it for others to find on your machine, etc. Copying it down onto your machine and doing these commands will restore the repository:

$ mkdir test
$ mv jekyll.git test/.git
$ cd test
$ git init
  Reinitialized existing Git repository in /Users/qrush/Dev/test/.git/
$ git checkout -f

So we’ve created a new folder for the repo, changed the folder name back to .git, woke git back up and restored all the changes from the latest commit.
"

Notes:

- TDD, C#, Git Repo, using Visual Studio 2022

- Deliverables:
  * Source Code
  * Git Repo clone

- Problem:
  * Basket
    + Add
    + Total
    + Apply Discounts
 
- Products
  * Butter: £0.80
  * Milk: £1.15
  * Bread: £1.00

- Offers:
  * 2 Butter - 1 Bread (-50%)
  * 3 Milk - 4th Milk free

- Scenarios
  * Basket: [Bread: 1, Butter: 1, Milk: 1] - Total: £2.95
  * Basket: [Bread: 2, Butter: 2] - Total: £3.10
  * Basket: [Milk: 4] - Total: £3.45
  * Basket: [Bread: 1, Butter: 2, Milk: 8] - Total: £9.00
  