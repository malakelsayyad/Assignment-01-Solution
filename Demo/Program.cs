namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Revision
            //Console.WriteLine("Hello World");
            //Console.WriteLine("Hello World");
            //Console.WriteLine("Hello World");
            //Console.WriteLine("Hello World");
            #endregion

            #region Variable Declaration
            // Variable Declaration
            //Datatype VariableName
            //int Number;
            // Allocate UnInitialized 4 Bytes at Memory

            //Console.WriteLine(Number); //Invalid

            //Number = 12;
            //Console.WriteLine(Number); //12

            //Variable
            //1. Name     : Number
            //2. Datatype :int
            //3. Value    :12
            //4. Size     :4bytes
            //5. Address

            //int Number = 12; //declaration and initialization



            //int Number01;
            //int Number02;
            //int Number03;

            //int Number01 = 12, Number02 = 3, Number03 = 4;
            //Console.WriteLine(Number01) //12


            #endregion

            #region Datatype (Value Type) : STACK

            //Datatype (Value Type) : STACK
            //declare variable

            //int Number; //value type

            //Allocate UnInitialized 4 Bytes At Stack
            // int : c# Keyword
            //bcl : Int32

            //Number = 5;
            //Console.WriteLine(Number);

            //Int32 Number = 12;
            //Console.WriteLine(Number); 
            #endregion

            #region Datatype (Reference Type) : Heap
            //Point P01; // refrence
            //Declare Reference From Type 'point'
            // point P01 : Can Refer To Object From Type 'Point'
            //8 Bytes Will Be Allocated At Stack For Refrence 'P01'
            //0 Bytes Will Be Allocated At Heap

            //Console.WriteLine(P01);
            //Console.WriteLine(P01.x); //inavlid

            //P01 = new Point();
            //New
            //1. Allocate The Number Of Required Bytes For Object at HEAP (8 Bytes + CLR Overhead)
            //2. Initialized The Allocated Bytes At Heap With The Defualt Value Of The Datatype
            //3. CallUser-Defined Constructor Exists
            //4. Assign The Object To Referenece 'P01'

            //Console.WriteLine(P01.X);//0
            //Console.WriteLine(P01.Y); //0
            //Console.WriteLine(P01); //Demo.Point

            //Point P02 = new point(); 
            //P02.X=12

            //Console.WriteLine(P01.X);
            //Console.WriteLine(P02.X);

            //P01=P02;

            //Console.WriteLine(P01.X);
            //Console.WriteLine(P02.X);



            #endregion

            #region Object
            // object O01;
            //Declare for reference  from type 'object'
            // O01 : can refer to instance from type 'object' or any type inherited from object

            //O01 = new object();
            //O01 = 1 ;
            //O01 = 'A';
            //O01 = 1.2;
            //O01 = true;
            //O01= new Point();

            //Console.WriteLine(O01.GetHashCode()); 

            //Console.WriteLine(O01); // Demo.Point 

            //Point P01 = new Point();
            //Console.WriteLine(P01.GetHashCode()); 

            //Console.WriteLine(P01.ToString()); //Demo.Point

            //P01.GetType();
            //P01.GetHashCode();
            //P01.Equals();

            #endregion

            #region Implicit and Explicit  Casting

            //casting : convert from any datatype to any datatype
            //1. implicit casting
            //int x = 5;
            //double y = /*(double)*/ x; //implicit casting (safe casting)
            //Console.WriteLine(y);

            //2. explicit casting
            //double x = 1.4;
            //int y = (int)x; // explicit casting (unsafe casting)
            //may cause problem

            //Console.WriteLine(y);

            //long x = 11111111111111111;
            //int y = (int)x; //explicit casting (unsafe casting)
            //Console.WriteLine(y);
            //Console.WriteLine(int.MaxValue); 
            #endregion

            #region Parse, Convert and TryParse
            //Parse :function

            //Console.WriteLine("Enter your age: ");
            //  int age = int.Parse(Console.ReadLine()); 
            // Console.WriteLine("Age : " + age);

            //Console.WriteLine("Enter your GPA: ");
            //double GPA = double.Parse(Console.ReadLine());
            //Console.WriteLine("GPA : " + GPA);

            //Convert : class

            //Console.WriteLine("Enter your age: ");
            //int age = Convert.ToInt32(Console.ReadLine());


            //Console.WriteLine("Enter your GPA: ");
            //double GPA = double.Parse(Console.ReadLine());

            //Console.WriteLine("Age : " + age);
            //Console.WriteLine("GPA : " + GPA);

            //TryParse : function

            // Console.WriteLine("Enter your age: ");
            // int age;
            // bool Flag = int.TryParse(Console.ReadLine(), out age);
            // Console.WriteLine("Age : " + age);
            // Console.WriteLine("Flag : " + Flag);
            #endregion

            #region Fractions and Discards
            //double X = 1.5;
            //float Y = 1.5f;

            //decimal Z = 1.5m;

            //int X = 1_000_000_000; //Discard _
            //Console.WriteLine(X); 
            #endregion

            #region Operators

            // 1.Unary Operators -> Works on one operand (Variable) ++ --
            // int X = 10;

            // ++
            // prefix [increments then print]
            // Console.WriteLine(++X); // 11
            // postfix [ print then increments ]
            // Console.WriteLine(X++); //10
            // Console.WriteLine(X); //11

            // --
            // prefix [decrements then print]
            // Console.WriteLine(--X); // 9
            // postfix [ print then decrements ]
            // Console.WriteLine(X--); //10
            // Console.WriteLine(X); //9


            // 2.Binary Operators -> works on 2 operands (VAriables)
            // + - / %

            //int Sum, Mul, Sub, Mod;
            //int Number01 = 2, Number02 = 6 ;

            //Sum = Number01 + Number02; //8
            //Mul = Number01 * Number02; // 12
            //Sub = Number01 - Number02; // -4
            //Mod = Number01 % Number02; // 2

            // 23 % 3 = 2

            // 3.Assignment Operators

            // int X;
            // X=4;
            // X += 2 ; // X + 2 
            // X -= 2 ; // X - 2 
            // X *= 2 ; // X * 2 
            // X /= 2 ; // X / 2 
            // X %= 2 ; // X % 2 

            // 4.Relational Operators [Comparision]

            //int X = 6, Y = 5;
            //Console.WriteLine(X == Y);
            //Console.WriteLine(X != Y);
            //Console.WriteLine(X > Y);
            //Console.WriteLine(X < Y);
            //Console.WriteLine(X >= Y);
            //Console.WriteLine(X <= Y);

            // 5.Logical Operators [AND ,OR ,NOT]

            // Console.WriteLine(!false); //! -> Not
            // Console.WriteLine(false && true); // && -> And Short Circuit
            // Console.WriteLine(true || false); // || -> Or Short Circuit

            // 6.Bitwise Operators

            // Console.WriteLine(!false); //! -> Not
            // Console.WriteLine(false & true); // & -> And Long Circuit
            // Console.WriteLine(true | false); // | -> Or Long Circuit

            // 7.Ternary Operators [Conditional]

            // bool Flag = 4 > 2 ;
            // Console.WriteLine(Flag);

            //string Flag = 4 < 2 ? "Correct" : "Not Correct" ;
            //Console.WriteLine(Flag);

            #endregion

            #region Operator Priority [Precedence] and Associativity

            /*
                1. Unary Operator (prefix)
                2. Round Brackets
                3. * / %
                4. + -
            */

            //int a = 20 ;
            //int b = 10 ;
            //int c = 15 ;
            //int d = 5 ;
            //int e ;

            //e= ( a + b) * c / d ; // (30 * 15) / 5

            //e= ((a + b) * c ) / d ; // (30 * 15) / 5

            //e= ( a + b) * ( c / d ); // (30)* (15 / 5)

            //e= a + ( b * c) / d ; // 20 + (150 / 5)

            #endregion
        }
    }
}
