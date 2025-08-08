# 📝 Console To-Do List App (C#)

A simple console-based **To-Do List** application written in C#.  
It allows you to add tasks, mark them as complete, and view both pending and completed tasks — all from the terminal.

---

## 🚀 Features

- **Add** new to-do items
    
- **Mark** tasks as completed
    
- **View** pending and completed tasks separately
    
- **Quit** when you’re done
    

---

## 📦 Requirements

- [.NET SDK 6.0+](https://dotnet.microsoft.com/en-us/download)
    
- Works on **Windows, macOS, and Linux**
    

---

## ⚙️ Installation & Running

```bash
# 1. Clone the repository
git clone https://github.com/Kushanth-Reddy/Todo-List-App.git

# 2. Move into the project folder
cd Todo-List-App

# 3. Build and run the application
dotnet run
```

---

## 🖥️ Usage

When you run the program, you’ll see:

```
Select an Option:
1. Add new Item
2. Complete an Item
3. List of Items
q. Quit
```

**Example session:**

```
Select an Option:
1. Add new Item
2. Complete an Item
3. List of Items
q. Quit
> 1
Name the item: Learn C#

Todo Added

Select an Option:
1. Add new Item
2. Complete an Item
3. List of Items
q. Quit
> 3

Pending Todos:
Learn C#

Completed Todos:
```

---

## 🛠️ How It Works

- **Lists:**
    
    - `pendingList` stores incomplete tasks.
        
    - `completedList` stores finished tasks.
        
- **Menu Loop:** Runs until the user chooses to quit.
    
- **Mark Complete:** Moves an item from `pendingList` to `completedList`.
    

---

## ✨ Possible Improvements

- Save and load tasks from a file for persistence
    
- Add due dates and priorities
    
- Input validation for safer number parsing
    
- Support deleting tasks instead of just marking them complete
    

---

## 📜 License

Licensed under the **MIT License** — free for personal or commercial use.
