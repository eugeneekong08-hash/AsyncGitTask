# AsyncGitTask

A small C# console program demonstrating async/await, Task.WhenAll, error handling, and Git branching.

## Answers

### Async

**1. What does `await` do?**
Await pauses that particular task while it waits, without freezing the rest of the program.

**2. Why was Task B faster than Task A?**
Task A was slower because each method had to wait for the previous one to finish before it could start. Task B was faster because all three methods started at the same time, so their 2-second waits overlapped instead of adding up.

**3. What is the difference between `Task` and `Task<string>`?**
`Task` represents work that will finish but doesn't give back any result, while `Task<string>` represents work that will finish and give back a string when it's done.

**4. Why do we use `Task.Delay` and not `Thread.Sleep` in an async method?**
`Task.Delay` only pauses that specific task, letting the rest of the program keep running, while `Thread.Sleep` freezes the entire program, including other tasks that could otherwise be running at the same time.

**5. What would happen in Step 3 if you removed the try/catch?**
Without the try/catch, the error thrown by `GetPaymentsAsync` would go unhandled and crash the program instead of being caught and shown as a friendly message.

### Git and GitHub

**6. What is the difference between Git and GitHub?**
Git is a tool that tracks changes and saves snapshots of a project on your own computer, while GitHub is an online platform where you can store and share that Git project with others.

**7. What is the difference between `git commit` and `git push`?**
`git commit` saves a labeled snapshot of your changes locally on your computer, while `git push` sends those saved commits up to GitHub so others can see them.

**8. What is a branch, and why did you use one in Step 3?**
A branch lets you test out and experiment without having an effect on the main project, until it's merged. I used one in Step 3 to build the error-handling feature safely, separate from `main`.

**9. What does the `.gitignore` file do?**
`.gitignore` tells Git to ignore certain files created by the project, like the `bin` and `obj` folders, so they don't get tracked or pushed to GitHub.

**10. Why is it better to make several small commits than one big commit?**
Small commits make it easier to see exactly what changed at each step, which makes it easier to find or undo a specific change if something goes wrong.
