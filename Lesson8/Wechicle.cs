using System;

public class Wechicle : IComparable
{
    int speed;
    string color;
    int power;
    bool isNew;
    bool isFree;
    string manufacter;
    public Wechicle()
	//Comment1
	//Comment2
    {
        speed = 100;
        color = "red";
        power = 1000;
        isNew = true;
        isFree = false;
    }
    public override string ToString()
    {
        return string.Format("wehicle: color {0}, speed {1}, power {2}", color, speed, power);
    }

    public int CompareTo(object obj)
    {
        if(obj is Wechicle)
        {
            Wechicle wechicleToCompare = (Wechicle)obj;
            //if (this.speed < wechicleToCompare.speed)
            //{
            //    return -1;
            //}
            //else if (this.speed > wechicleToCompare.speed)
            //{
            //    return 1;
            //}
            //else
            //{
            //    return 0;
            //}

            return this.speed.CompareTo(wechicleToCompare.speed);
        }
        else
        {
            //!ERROR!MESSAGE!
            Console.WriteLine("Object is not correct!!!");
            return 0;
        }
    }

    public Wechicle(string Color, int Speed):this()
    {
        color = Color;
        speed = Speed;
        isFree = true;
    }
    public Wechicle(string Color, int Speed, int Power) : this()
    {
        color = Color;
        speed = Speed;
        power = Power;
        isFree = true;
    }
    public Wechicle(string Color, int Speed, int Power, bool IsNew, bool IsFree)
    {
        speed = Speed;
        color = Color;
        power = Power;
        isNew = IsNew;
        isFree = IsFree;
    }
}
