Understanding Access Modifiers

- Public
    - Method or class member can be accessed by any other code within your program

- Protected
    - Method or calss member can be accessed only by code within the class or a subclass

- Private
    - Method or class can only be accessed by code within the class definition itself.

--EX--

class A {
    public void fnA1();
    protected void fnA2();
    private void fnA3();
}

class Program {
    static void Main() {
        A clsa = new A();

        clsa.fnA1();  // this works
        clsa.fnA2();  // error protected
        clsa.fn3();  // only available in class A
    }
}

class B : A {
    fnB1() {
        fnA1(); // this works, B inherits from A master class
        fnA2(); // this works, B is a subclass of A
        fnA3(); // this doesn't work, only code inside class has access to this 
    }
}