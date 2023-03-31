combo DEADLY {
    wait(20);
    set_val(PS4_R3, 100);
    wait(90);
    set_val(PS4_R3, 0);
    set_val(PS4_R2, 0);
    wait(90);
    nowshoot= 999;
    deadeye = TRUE;
    wait(90);
}

combo DEADLY2 {
    set_val(PS4_L2,100);
    set_val(PS4_R3,100);
    set_val(PS4_R2,0);
    wait(200);
    wait(40);
    set_val(PS4_L2,100);
    set_val(PS4_R3,0);
    set_val(PS4_R2,0);
    wait(200);
    wait(40);
    // set_val(PS4_R3,0);
    // wait(300);
    
    // nowshoot=TRUE;
    deadeyeINIT = 100;
    wait(40);
    // deadeyeEND = 1;
    wait(40);
    wait(400);
    wait(40);
}
