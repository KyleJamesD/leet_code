class add_digits {

   static int addDigits(int num) {
        int num2 = 0;
        while (num > 0)
        {
            int num1 = num % 10;
            num2 = num1 + num2;
            num = num / 10;
        }
        if (num2 > 9)
        {
          num2 = addDigits(num2);
        }
        return num2;
        
    }
    public static void main(String[] args){
        System.out.println(addDigits(38));
        System.out.println("the awnser should be 2");

    }

    };