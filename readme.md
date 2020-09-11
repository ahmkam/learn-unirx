# Learn UniRx

I have been playing around with UniRx for quite some time, though haven't really looked into it in a structured way. So, I decided to learn it in proper manner and post the content to this repository as I continue my learning journey. It contains UniRx related concepts and real-word examples.

**Unity version**: 2019.3.11f1\
**UniRx version**: 7.1.0


## Introduction
UniRx is a reactive programming extension for Unity created by [Yoshifumi Kawai](https://github.com/neuecc)
- It is based on the observer pattern
- Used for asyncronous and even-driven programming
- Allows writing concise and elegant code 
- Optimized for C# Unity
- Uses LINQ-style syntax


Lets look at a basic example to implement a functionality where we process only the first left mouse click:
```csharp
Observable.EveryUpdate()
.Where(_ => Input.GetMouseButtonDown(0))
.First()
.Subscribe(_ => Debug.Log("first left mouse click"));
```
What the code is doing:
1. Opens an Update stream
2. Check if left mouse button is clicked
3. if clicked, process only the first click event
4. and prints "first left mouse click"

In a classical non-rx way, the above functionality would look something like this:
```csharp
bool mouseClicked;
private void Update()
{
  if (!mouseClicked)
  {
      if (Input.GetMouseButtonDown(0))
      {
          mouseClicked = false;
          Debug.Log("first left mouse click")
      }
  }
}
```

So which one do you find concise?
It takes a bit of time to get the hang of reactive programming, but you will really enjoy it once you get the hang of it!







