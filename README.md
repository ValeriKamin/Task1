#  Завдання #01 — Компонент **TimePickerControl** (.NET WinForms)

##  Опис
Цей репозиторій містить розроблений компонент `TimePickerControl` для WinForms — користувацький елемент з двома `ComboBox`, що дозволяють вибрати годину та хвилини. Компонент реалізовано як бібліотеку для повторного використання, включаючи підтримку іконки в Toolbox та можливість розповсюдження через NuGet.

---

##  Структура каталогу

```
/
├── Task01/
│   ├── Task01.sln
│   ├── ControlLib/              # Бібліотека компонента
│   │   ├── TimePickerControl.cs
│   │   ├── TimePickerControl.Designer.cs
│   │   ├── TimePickerControl.resx
│   │   ├── TimePickerControl.ico
│   │   └── ControlLib.csproj
│   ├── DesktopApp/              # Тестовий WinForms додаток
│   │   ├── Form1.cs
│   │   ├── Form1.Designer.cs
│   │   ├── Form1.resx
│   │   └── DesktopApp.csproj
│   └── README.md
└── 01 621 П’яточкинПП.docx      # Звіт до завдання
```

---

##  Основна функціональність

- Властивості: `SelectedHour`, `SelectedMinute`
- Подія: `SelectedTimeChanged`
- Автоматичне оновлення годин/хвилин при виборі
- Повна інтеграція у Toolbox з іконкою `TimePickerControl.ico`

---

## Використання

```csharp
int hour = timePickerControl1.SelectedHour;
int minute = timePickerControl1.SelectedMinute;
```

```csharp
timePickerControl1.SelectedTimeChanged += (s, e) =>
{
    MessageBox.Show("Час змінено!");
};
```

---

## SOLID-принципи

| Принцип | Реалізація |
|--------|-------------|
| **S** — Єдина відповідальність | Компонент відповідає лише за вибір часу |
| **O** — Відкритість/закритість | Легко розширюється, не змінюючи код |
| **L** — Підстановка Лісков | Наслідує `UserControl`, взаємозамінний |
| **I** — Розділення інтерфейсу | Має тільки потрібні властивості |
| **D** — Інверсія залежностей | Зовнішній код підписується на подію, не залежить від реалізації |

---

фотографии 

![image](https://github.com/user-attachments/assets/ee801128-cdcc-4a9f-a00d-494894843fc7)

![image](https://github.com/user-attachments/assets/e6840f23-204e-4dc0-892b-c277c12b2527)

![image](https://github.com/user-attachments/assets/208746f1-33d7-4fc0-a61c-81f085ef3319)



---

##  NuGet пакет

Після збирання рішення у режимі Release буде створено файл:

```
ControlLib/bin/Debug/TimePickerControl.1.0.0.nupkg
```

Його можна підключати у будь-який WinForms-проєкт.

---

##  Автор

Мурзін В.А., група 611  
---
