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

Here is a picture of the Complexity. My IDE doesn't have any way to have a good way of presenting Code Metrics unless you buy enterprise edition, which i am not willing to do :) But i found a third-party plugin, so this is what i got.
[![https://gyazo.com/935b03603f0527c21c90fac4fd8cd220](https://i.gyazo.com/935b03603f0527c21c90fac4fd8cd220.png)](https://gyazo.com/935b03603f0527c21c90fac4fd8cd220)


- D) CC metrics variation.

It is clearly the strict CC2 variation. It can be seen in the calculate TriangleType. It is counting all the operators aswell.

- E) Refreactoring of Code.

I fixed all Code smells and refractored the Calculate Triangle Type function.

After refractoring. It got down to total of 9 issues which i personaly see as allmost impossible to get rid of. And are quite weird issues. And all functions with a complexity below 5
[![https://gyazo.com/a0a3b7bc83b271da688e0644e0e1e12b](https://i.gyazo.com/a0a3b7bc83b271da688e0644e0e1e12b.png)](https://gyazo.com/a0a3b7bc83b271da688e0644e0e1e12b)

- F) Tests cases.

Tests can be found here: [Link](https://github.com/Games-of-Threads/TestEX1-DFH). But it has gained some more tests and updates since last time. The xUnitTests written in C# can be found here: [UnitTest1.cs](https://github.com/Games-of-Threads/TestEX2-DFH/blob/master/TriangleTest/TriangleTestingProject/UnitTest1.cs) 

##### First run of tests
[![https://gyazo.com/d0ecbfbb3052af7c74cc828242623a23](https://i.gyazo.com/d0ecbfbb3052af7c74cc828242623a23.png)](https://gyazo.com/d0ecbfbb3052af7c74cc828242623a23)

##### Refractoring and fixing bugs of code.
Most of the failed tests, were just weird tests and things like math.round i didn't remember i did. Basicly didn't refractor the actual class, but the tests cases, because it was more fitting.
[![https://gyazo.com/467069455650d8b1b0482924374f2f97](https://i.gyazo.com/467069455650d8b1b0482924374f2f97.png)](https://gyazo.com/467069455650d8b1b0482924374f2f97)

## 3. Peer Review Checklist
The checklist compiles tips and bests practises when it comes to code reviewing. It is guidelines to follow to obtain most out of code reviewing. But also guidelines that will make reviewing effective and bring more value & money for the effort. An example would be to be slow and thorough with no more than 200 to 400 lines of code in one sitting. This will make the reviewing thorough and more likely to detect defects. One of the biggest take-aways in my opinion is to find the defects before launch, if critical/major defects are shipped for launch that is where all the horrible things can go wrong, and also the costlyness of fixing a bug after production is huge. #10 seels very usefull. By doing a little bit of code review each day, you not only strenghen reviewing. But also make developers more conscientious of their code and how they write because they know their code will probably be reviewed that same day.

## 4. Code Review
I'm not a big javawizz. So this is purely guesswork.

It looks like, it still adds the person to the list even tho it throws the exception. If i take my expience in golang and C#, you are still able to produce exceptions and continue in the code, and choose how you will handle the exceptions. In this example, if you add a minor to the personslist, it will throw an exception because the difference of subtracting a minors birthyear to the current year will produce results below 18. But it will still go and add the person to the list. This means the first test to add minor will go through fine. The first assertion of there being nobody in the list from the start is true. Then it makes a new person which is a minor and then adds to t he list, and as expected it gets an exception. But my suspicion is that the "underTest" is still the same catalog being used in the tests. The first test was fine, but the minor is in the list now. When the addingAdult starts, it asserts that there should be nobody in the list. But there is! The minor got added dispite the exception thrown.

This is purely guesswork. :D

If this is the issue, there is a few ways to solve it.

First way, would be to add "else" after the if (Calender.getInstance()............<18) statement. So 
```java
throw new IlegalArgumentException("only adults admitted.");
} 
else 
{
people.add(person)
}
```

Another way, would be to standardize the test more. Instead of having a pirvate final catalog object that is being used for all tests. Make a new catalog object for every test. If more things needs to be prepared before tests can begin. 

```java
@Test
public void addintAnAdultShouldSucceed() {
  underTest = new Catalog();        <<<<<<-------
  asserEquals(0, underTest.getNrOfPeople());
  Person p = new person(1985);
  underTest.addPerson(p);
  asserEquals(1, underTest.getNrOfPeople());
}
```
Or maybe just use a complete new object every test.

I would recommend making a method/function to prepare everything before hand ea. If the tests needed an object ea. Catalog object. I would make a SetupTest() method which would return a fresh new catalog object in the right condition fit for testing. This way can be extended to all things. Maybe you would have some static objects/servers. Then a ResetAndPrepareForTest() method wouldn't be a bad idea to throw in before tests begin, so previus tests doesn't screwer the results of the new ones. Unless it is on purpose ofcause. 

And that is maybe the final solution. To take previus tests into consideration. To not assert 0, but 1. Because it might be meant for the minor to be added allthrough with an exception.

```java
asserEquals(1, underTest.getNrOfPeople());
```

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
It is hard for me to pick the most essential things, because they were in my opinion some very appealing things to consider when thinking about testing, and also revewing, and working as a software developer in scrum. I'm not sure if i think they are the most essential things, but it is atleast the things i think was most starteling things to learn.

One of the things that i thought was very essential and made me think was. That testers still exists, but it is apart of scrum and scrum is not just a team of frotnend and backend developers. But a crosstalented team that should be able to do all tasks within software development. This it is essential to learn to test, because the future demands testing from software developers. 


Another thing was that it is quite possible to find defect earlier in the process, never realy occured to me, that by pressing on and holding regular review mettings on the actual system requirements with the product owner is a way to actully root out so many defects early on. And by discovering the bugs this early will be very cheap compared to discovering them later. The example from what gitte told, was that maybe it costs 10 kr,- to fix the requirement analysis paper, but then it costs 100 to fix the bug found during development, but it might cost 1000 kr,- to fix when it is being found right before launch maybe because many things need to change before the bug is fixed. And it might even costs lives if defect not found before shipping. So thinking about discovering defect early is a major thing to think about.


One more thing that i think was essential from the lecture, was that people rather want 1 feature that works pretty good and smooth every time, than alot of features that don't work so well, only some of the times. That it is best to focus on the non-functional issues, because those are the ones we tend to miss or get wrong. 
