# Student List LINQ Demo

This is a simple C# console application that demonstrates the use of **LINQ** with a list of `Student` objects.

## Features

- Define a `Student` class with the following properties:
  - `Id` (int): Student ID
  - `Name` (string): Student name
  - `Age` (int): Student age

- In `Main`, create and populate a list of at least 5 students.

## LINQ Queries Demonstrated

This application includes the following LINQ queries:

- ✅ Print all students.
- 🔍 Find students aged between 15 and 18.
- 🔠 Find students whose names start with "A".
- ➕ Calculate the total age of all students.
- 🧓 Identify the oldest student.
- 📈 Sort students by age in ascending order.

## Example Output

```bash
All Students:
1. Alice - Age: 17
2. Bob - Age: 16
...

Students aged 15 to 18:
- Alice
- Bob

Students whose names start with 'A':
- Alice

Total age of all students: 86

Oldest student: Charlie (Age: 19)

Students sorted by age:
1. Bob - 16
2. Alice - 17
...
