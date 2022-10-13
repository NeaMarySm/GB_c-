Console.Clear();
int ax = 40, ay = 1, bx = 1, by = 30, cx = 80, cy = 30;

Console.SetCursorPosition(ax, ay);
Console.WriteLine("*");
Console.SetCursorPosition(bx, by);
Console.WriteLine("*");
Console.SetCursorPosition(cx, cy);
Console.WriteLine("*");

int count = 0;
int x = ax;
int y = ay;
while(count < 10000){
    int top = new Random().Next(0, 3);
    if(top == 0){
        x = (x + ax)/2;
        y = (y + ay)/2;
    }
    if(top == 1){
        x = (x + bx)/2;
        y = (y + by)/2;
    }
    if(top == 2){
        x = (x + cx)/2;
        y = (y + cy)/2;
    }
    Console.SetCursorPosition(x, y);
    Console.WriteLine("*");
    count++;
}