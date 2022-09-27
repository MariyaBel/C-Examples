// Игра Пирамидки (перенос блинчиков с 1 пирамдки на 3ю, 2я - промежуточная)

void Towers (string with="1", string on ="3", string some ="2", int count =3)
// strint 1 - c которой снимают, 3 - на которую одевают, 2 - промежуток, count - число блинов
{
    if (count>1) Towers(some, on, with, count-1);
    Console.WriteLine($"{with}>>{on}");
    if (count>1) Towers(some, on, with, count-1);
}
Towers();