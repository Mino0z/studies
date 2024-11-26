public static double TrianglePerimeter(int a, int b, int c, int precision=2)
{   
    
    if(a < 0 || b < 0 || c < 0 || precision < 2 || precision >8){
        throw new ArgumentOutOfRangeException("wrong arguments");
    }
    if(a + b < c || b + c < a || c + a < b){
        throw new ArgumentException("object not exist");
    }
    double perimeter = a + b + c;
    
    return Math.Round(perimeter, precision);
    //throw new NotImplementedException();
}
