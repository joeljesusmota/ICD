
//*********************************  Estrucutras de control de flujo

// Estructuras de control condicional

// Sentencia if
int edad = 19;
if (edad > 18) 
{
  // output: "es mayor de 18");
}

// Sentencia else

int time = 20;
if (time < 18) 
{
  // output: "Good day."
} 
else 
{
  // output: "Good evening."
}
// Outputs "Good evening.

// Sentencia else if

int time = 22;
if (time< 10) 
{
  // output: "Good morning.");
} 
else if (time< 20) 
{
  // output: "Good day."
} 
else 
{
  // output: "Good evening."
}
// Outputs "Good evening."


// Sentencia switch

int day = 4;
switch (day) 
{
  case 1:
    // output: "Monday"
    break;
  case 2:
    // output: "Tuesday"
    break;
  case 3:
    // output: "Wednesday"
    break;
  case 4:
    // output: "Thursday"
    break;
  case 5:
    // output: "Friday"
    break;
  case 6:
    // output: "Saturday"
    break;
  case 7:
    // output: "Sunday"
    break;
}
// Outputs "Thursday" (day 4)

/**************************************/

// Estructuras de control iterativas

// Bucle while

int i = 0;
while (i< 5) 
{
  /*
    0
    1
    2
    3
    4
  */

  i++;
}

// do/while

int i = 6;
do 
{
  i++;
  // output: 7
}
while (i< 5);

// Bucle for

for (int i = 0; i< 5; i++) 
{
  /*
    0
    1
    2
    3
    4
  */
}

// foreach

string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
foreach (string i in cars) 
{
  /* 
    
  */ 
}
