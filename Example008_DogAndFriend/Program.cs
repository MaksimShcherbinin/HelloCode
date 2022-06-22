Console.Write("Введите начальное расстояние меджду друзьями (м) = ");
double distance = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите скорость первого друга, от которого бежит собака (м/с) = ");
double firstFriendSpeed = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите скорость второго друга, к которому бежит собака (м/с) = ");
double secondFriendSpeed = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите скорость собаки (м/с) = ");
double dogSpeed = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите конечное расстояние между друзьями (м) = ");
double stopDistance = Convert.ToDouble(Console.ReadLine());
int count = 0;
double time = 0;
bool friend = true; // Dog runs away from first friend
while(distance > stopDistance)
{
    if(friend) time = distance/(dogSpeed + secondFriendSpeed);
    else time = distance/(dogSpeed + firstFriendSpeed);
    distance = distance - time*(firstFriendSpeed + secondFriendSpeed);
    count++;
}
Console.Write("Собака пробежит " + count + " раз(а).");