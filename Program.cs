//task21

double distance_of_two_point_3d(x1, x2, y1, y2, z1, z2){
    double dist = Math.Sqrt(Math.Pow(x1-x2, 2) + Math.Pow(y1-y2, 2) + Math.Pow(z1-z2, 2));
    return dist;
}

int a1 = 3;
int a2 = 6;
int a3 = 8;
int b1 = 2;
int b2 = 1;
int b3 = -7;

Console.WriteLine($"Расстояние между точками равно");
Console.WriteLine(distance_of_two_point_3d(a1, b1, a2, b2, a3, b3));