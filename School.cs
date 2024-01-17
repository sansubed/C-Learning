 class School{
    int schoolID;
    int foundDate;

    public School(int ID, int _founfDate){
        schoolID = ID;
        foundDate = _founfDate

    }

    //static - meaning it does not belong to the object, no reference (this) to static method
    public static void Main(){
        School sc1 = new School(1, 1998);
        /* although this statement is syntatically correct, C# compiler acts as there is not such field schoolID in the object in the first place.
          - that field and other field are inside School and declared as private, not visible from inside when there is no access modifier 
          - "public" in the School constructor
        */
        sc1.schoolID = 2; 
    }

}