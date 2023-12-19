int i1 = 5;
int i2 = 6;
int sum = i1 + i2; //Если тип данных у операндов одинаков int то и sum будет int
Console.WriteLine(sum);

long l1 = 6;
long sum2 = l1 + i1; //Если типы данных у опрандов разные то назначается самый емкий long 
Console.WriteLine(sum2);

double d1 = 5.5;
double sum3 = d1 + i1;

int product1 = i1 * i2;
long product2 = l1 * i1;
double product3 = i1 * d1;
Console.WriteLine(product1);
Console.WriteLine(product2);
Console.WriteLine(product3);


int quotient = i1 / i2;  // Некорректный тип данных!!!
Console.WriteLine(quotient);

d1 = 6;
double quotient2 = i1 / d1; // Корректый тип данных
Console.WriteLine(quotient2);
