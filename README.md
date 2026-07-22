# C# Coding Challenges

This repository is my personal C# practice space for strengthening programming fundamentals, improving problem-solving skills, and gradually progressing toward more practical object-oriented and .NET development exercises.

The goal is not simply to complete challenges once. It is to practise solving problems from scratch, revisit weaker areas, improve confidence, and build a stronger understanding of how C# code works.

## Purpose

The main focus of this repository is to practise and reinforce:

* loops and conditionals
* strings, characters, arrays, and collections
* counters and comparison logic
* nested loops
* frequency counting
* duplicate detection
* edge case handling
* debugging and problem solving
* classes and objects
* constructors and properties
* working with collections of objects
* object responsibilities and interactions
* explaining code clearly

As the repository progresses, it will also move into more practical C# and .NET concepts such as:

* encapsulation
* inheritance
* abstraction
* interfaces
* services
* DTOs
* dependency injection
* APIs and controllers
* unit testing
* async/await
* exception handling

## Approach

For many of these exercises, I intentionally solve the core problem manually rather than relying on methods that directly perform the main task.

Depending on the challenge, I may avoid shortcuts such as:

* `Reverse()`
* `Max()`
* `Min()`
* `Sort()`
* `Distinct()`
* LINQ methods such as `Where()`, `Select()`, `Count()`, and `Sum()`

This is intentional and allows me to practise the underlying logic using:

* loops
* conditions
* counters
* variables
* lists
* nested iteration
* state tracking

Normal C# and .NET features are still used where appropriate, including methods such as `Contains()`, `IndexOf()`, `Split()`, `StringBuilder`, and character helper methods.

## Tooling

GitHub Copilot and AI code completion are disabled while solving the challenges.

I use normal development tools such as:

* IntelliSense
* compiler errors
* breakpoints
* the Visual Studio debugger

These are part of the learning process and help me inspect values, understand execution flow, identify mistakes, and debug solutions independently.

AI may be used after I have attempted or completed a challenge to review the finished solution, suggest cleaner C# conventions, identify edge cases, or help refactor code while preserving the original logic.

## Repository Structure

The repository is organised into learning phases so that progress can be tracked over time.

```text
Challenges/
├── Phase_01_Fundamentals/
└── Phase_02_OOP/
    └── Week-01/
        ├── 01-Card-Collection/
        │   ├── Card.cs
        │   ├── CardCollection.cs
        │   └── CardCollectionChallenges.cs
        └── 02-Player-And-Cards/
            ├── Player.cs
            └── PlayerAndCardsChallenges.cs
```