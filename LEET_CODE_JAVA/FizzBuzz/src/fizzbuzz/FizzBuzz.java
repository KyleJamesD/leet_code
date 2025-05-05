/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package fizzbuzz;

import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author kyled
 */
public class FizzBuzz {

    
    
    public List<String> fizzBuzz(int n) {

        List<String> data = new ArrayList();

        for (int i=0; i < n; i++)
        {
            if (i%3 == 0 && i % 5  == 0){
                data.add(n,"FizzBuzz");
            }
            else if (i % 3 == 0){
                data.add(n,"Fizz");
            }
            else if (i % 5  == 0) {
                data.add(n,"Buzz");
            }
            else {
                data.add(n,Integer.toString(n)); 
            }
        }
        return data;
    }
    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
    }
    
}
