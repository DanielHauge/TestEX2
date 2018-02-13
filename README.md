# Test exercise 2 (Static Test Techniques)
This is a mini project for the test course. The excersise is based off the description in this [resource](https://github.com/datsoftlyngby/soft2018spring-test-teaching-material/blob/master/exercises/Static%20Test%20Techniques%20Exercises.pdf)

## Description
This exercise goal is to do 6 tasks involving doing some static code analysis of a triangle program. Explaining concepts and talk about essential parts of coding standard and also pick highlights of a guest lecture and more.

The result is this repositories testcase code and the below documentation. 

## 1. Moddle Quiz
The moddle quiz has been submitted on moddle.

## 2. Static Code Analysis of Trinagle program
- A) Install Metrics software in your IDE.
I've installed ReSharper and Code Metrics in visual studio. (Note however, that Code metrics as a built in function is only availabe in enterprise edition.

- B) Coding standards.

Here is a long list of all Violations of coding standards i've commited in the program according to standard resharper protocol. [Code Smells](CodeSmells.txt)

Allthrough here is a small example from within the IDE about the most important ones which it found 16 of.
[![https://gyazo.com/6e77ccdaf438fddfe6ef3cc5649cccac](https://i.gyazo.com/6e77ccdaf438fddfe6ef3cc5649cccac.png)](https://gyazo.com/6e77ccdaf438fddfe6ef3cc5649cccac)

- C) Code Metrics.

Here is a picture of the Complexity. My IDE doesn't have any way to have a good way of presenting Code Metrics unless you buy enterprise edition, which i am not willing to do :) But this is what i got.
[![https://gyazo.com/935b03603f0527c21c90fac4fd8cd220](https://i.gyazo.com/935b03603f0527c21c90fac4fd8cd220.png)](https://gyazo.com/935b03603f0527c21c90fac4fd8cd220)


- D) CC metrics variation.

It is clearly the strict CC2 variation. It can be seen in the calculate TriangleType. It is counting all the operators aswell.

- E) Refreactoring of Code.

I fixed all Code smells and refractored the Calculate Triangle Type function.

After refractoring. It got down to total of 9 issues which i personaly see as allmost impossible to get rid of. And are quite weird issues. And all functions with a complexity below 5
[![https://gyazo.com/a0a3b7bc83b271da688e0644e0e1e12b](https://i.gyazo.com/a0a3b7bc83b271da688e0644e0e1e12b.png)](https://gyazo.com/a0a3b7bc83b271da688e0644e0e1e12b)

- F) Tests cases



## 3. Peer Review Checklist
The checklist compiles tips and bests practises when it comes to code reviewing. It is guidelines to follow to obtain most out of code reviewing. But also guidelines that will make reviewing effective and bring more value & money for the effort. An example would be to be slow and thorough with no more than 200 to 400 lines of code in one sitting. This will make the reviewing thorough and more likely to detect defects. One of the biggest take-aways in my opinion is to find the defects before launch, if critical/major defects are shipped for launch that is where all the horrible things can go wrong, and also the costlyness of fixing a bug after production is huge. #10 seels very usefull. By doing a little bit of code review each day, you not only strenghen reviewing. But also make developers more conscientious of their code and how they write because they know their code will probably be reviewed that same day.

## 4. Code Review

## 5. Coding standards
For me, coding convetions/standards change depending on IDE, screensize and language used. 

##### Naming Conventions
I see a good overview and readability from having a naming convention. But stricly following rules for putting underscore before private static variables, or allways use camelcase in surden situations, i'm not realy a fan of that. I've never realy read a peace of code and thought, wouw this is so complicated i dont even know what is going on here. Purely by being confused about the names. But ofcause it adds to readability and visibility of the code if using proper naming conventions.

##### Comment Conventions
All comments needs to not attract attention away from the actual code, and should be above the actual method, but no comments inside method. Unless explanatory method.

##### Indentation style
All curly brackets most be vertically alligned or opened and closed on the same line. This grants good overview and removes confusingness.

But i find Indentation style **VERY** Important for a team, to increase visibility and readability. But it should differ alot for which language is being used.

I personaly like GNU
```
while (x == y)
  {
    something();
    somethingelse();
  }
```
or Allman
```
while (x == y)
{
    something();
    somethingelse();
}
```
I Dislike something like Pico indentation style
```
while (x == y)
{   something();
    somethingelse(); }
```

##### Function/Method Length.
I find restricting or limiting lines of code for functions and methods are important. Especially for teams. Maybe you know what a 500 lines of code function does because you made it, but someone might need to figure out what it does and need to read a complicated 500 line function through, which gets very complicated.

The actual lines in my opinion should depend on Screensize and IDE used. A good rule of thumb, a method/fucntion should only take up 3/4 of the height of the screen. Or about what fits a screen in the IDE. In visual studio with zoom 100%. it is about 72 lines of code.



## 6. Highlights from lecture
