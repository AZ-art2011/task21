//task21

double distance_of_two_point_3d(int x1, int x2, int y1, int y2, int z1, int z2){
    double dist = Math.Sqrt(Math.Pow(x1-x2, 2) + Math.Pow(y1-y2, 2) + Math.Pow(z1-z2, 2));
    return dist;
}

int a1 = 3;
int a2 = 6;
int a3 = 8;
int b1 = 2;
int b2 = 1;
int b3 = -7;

Console.WriteLine("Расстояние между точками в первом задании равно");
Console.WriteLine(distance_of_two_point_3d(a1, b1, a2, b2, a3, b3));

int a1_1 = 7;
int a2_1 = -5;
int a3_1 = 0;
int b1_1 = 1;
int b2_1 = -1;
int b3_1 = 9;

Console.WriteLine("Расстояние между точками во втором задании - ");
Console.Write(distance_of_two_point_3d(a1_1, b1_1, a2_1, b2_1, a3_1, b3_1));