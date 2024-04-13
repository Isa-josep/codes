using System;
class Program{
     struct Ura{
        public string name;
        public  int age;
        public bool? isStudent;
        public bool? isAlive;
    }
    static void Main(){
        int a=2; 
        List<Ura> list = new List<Ura>();
        
        for(int i=0;i<a;i++){
            Ura N;
            N.name = Console.ReadLine();
            N.age = Convert.ToInt32(Console.ReadLine());
            N.isStudent = Convert.ToBoolean(Console.ReadLine());
            N.isAlive = Convert.ToBoolean(Console.ReadLine());
            list.Add(N);
        }
        foreach(var x in list){
            Console.WriteLine(@"Name: {0}, Age: {1}, isStudent: {2}, isAlive: {3}",x.name,x.age,x.isStudent,x.isAlive);
        }
    }
}