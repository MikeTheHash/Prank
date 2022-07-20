using System;
using System.IO;

class HelloWorld {
    static void Main() {
        string default_name = "Hello motherfucker";
        for(int i = 0; i<1000; i++){
            File.Create($"{default_name}_n{i}");
        }
    }
}
