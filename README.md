# Battle – Character System

A small ASP.NET Core Razor Pages project based on an object-oriented programming assignment.  
It presents a simple character and skill system inspired by **God of War Ragnarök** and shows key OOP concepts in practice.

## Features

- base class `Wojownik`
- derived classes: `Kratos`, `Atreus`, `Freya`, `Thor`
- inheritance and polymorphism
- method overriding
- sealed class (`Thor`)
- RTTI demo using `GetType()` and `is`
- simple web interface built with Razor Pages and Bootstrap
- action log showing character interactions

## Technologies

- C#
- .NET
- ASP.NET Core Razor Pages
- Bootstrap

## Project Structure

- `Battle.Core` — domain logic and character classes
- `Battle.Web` — web interface

## What happens on the website

The website displays a small team of characters as interactive cards.  
Each character has their own actions, such as attack, special ability, and identification.

Users can:
- trigger character actions
- test interactions between characters
- run an RTTI demo
- reset the current state

All actions are shown in a log panel on the page.

## OOP Concepts Demonstrated

This project demonstrates:
- encapsulation
- inheritance
- polymorphism
- virtual and override methods
- runtime type checking
- separation of logic and presentation layers

## Screenshots

[image1.png]
[image2.png]
[image3.png]

## Purpose

This project was created as a university assignment and later extended into a simple web application to present the logic in a more visual and interactive form.
