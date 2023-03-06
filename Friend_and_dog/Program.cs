int count =  0;
int distance = 1000;
int firstFriendSpeed = 1;
int secondFriendSpeed = 2;
int dogSpeed = 5;
int friend = 2;
int time;
while(distance > 10)
{
    if(friend>1)
    {
        time = distance/(firstFriendSpeed + dogSpeed);
        friend = 1;
    }
    else
    {
        time = distance/(secondFriendSpeed + dogSpeed);
        friend = 2;
    }
    distance = distance - (firstFriendSpeed+secondFriendSpeed) * time;
    count++;
}
Console.Write("Собака пробежала ");
Console.Write(count);
Console.WriteLine(" раз.");