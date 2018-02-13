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

## 4. Code Review

## 5. Coding standards

## 6. Highlights from lecture
