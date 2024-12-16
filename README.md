### Please note before start reading
Those code examples about design pattern have the purpose of personal use, to easily remember the patters; it's like a notepad. I took the following examples from Youtube and some web articles.

The major source of the examples is a Youtube channel of [DoableDanny](https://www.youtube.com/@doabledanny/videos), he's a very good developer. I suggest to all to buy 📒his book about design pattern 📒 , it's very clear.

# Mediator with Observer pattern
In our case PostDialogBox  class now is a Mediator, contains the business logic for how ui should interact with each other ui this class is also a Observer, wich recive notice whenever one UI Component changes.

In example add the necessary listener on every part of mediator pattern, with observer tecnique, every method is passed like a delegate, event handler parameter is a delegate, delegate is a way to pass a method like a ojbect. (You can see my examples in an other )
