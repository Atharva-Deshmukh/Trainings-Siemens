/*
    MenuPicker returns one of the following:

    "addition" if symbol is A
    "division" if symbol is D
    blank string if input is something else
*/

void MenuPicker(char Symbol){
    if(Symbol=='A'){
        return "addition";
    }

    else if(Symbol=='d'){
        return "division";
    }

    else{
        return "";
    }
}

void Addition(){

}

void Division(){
   

}

/*
    executes one of the following:

    addition() function if name is "addition"
    division() function if name is "division"
*/

void Decider(string Name){
    if(Name=="addition"){
        Addition();
    }

    if(Name=="Division"){
        Division();
    }
}

/*
    It takes character (either A OR B) as an argument and then choses which function to call accordingly
*/

void Calculator(char Symbol){
    string name=MenuPicker(Symbol);
    Decider(name);
}