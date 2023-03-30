if((get_lval(PS4_LEFT)&&get_ptime(PS4_LEFT)>800)||(get_lval(PS4_RIGHT)&&get_ptime(PS4_RIGHT)>800)||event_press(PS4_OPTIONS))
{
  MENU_SECTION_RUNNING=TRUE; 
  SNIPER_RIFLE=FALSE;
}

if(MENU_SECTION_RUNNING)
  {
    if(event_press(PS4_CROSS)) PLACE_ON_MENU = PLACE_ON_MENU + 1;  
    if(event_press(PS4_CIRCLE))PLACE_ON_MENU = PLACE_ON_MENU - 1; 
    if((PLACE_ON_MENU<0)||(get_lval(PS4_CIRCLE)&&get_ptime(PS4_CIRCLE)>800)){ SNIPER_RIFLE=TRUE; PLACE_ON_MENU=0; MENU_SECTION_RUNNING=FALSE;  } 
  }
    // else