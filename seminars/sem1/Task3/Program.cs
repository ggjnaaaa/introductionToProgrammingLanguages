﻿// Задача №3
// Напишите программу, которая будет выдавать название дня недели по заданному номеру.

string[] days = {
    "Понедельник",
    "Вторник",
    "Среда",
    "Четверг",
    "Пятница", 
    "Суббота",
    "Воскресенье"
}

int day = int.Parse(Console.ReadLine()??"0");

Console.WriteLine(days[day + 1]);