  if(!get_val(PS4_L2) && event_press(PS4_L3)  ){ //real r1 not swap!
	if(double_tap) //real r1
				{
          // if(pressonce) {combo_stop(r1); pressonce = FALSE;}
					// set_val(PS4_L3,100)
					// set_val(PS4_R1,0)
					// combo_run(RUMBLE_ON);
          gvd1 = TRUE
					// combo_run(autospin_right);
					// display_title = TRUE;
				}
				else
					double_tap = 250;
      }
      if(gvd1) combo_run(autospin_right); 

      if(combo_running(autospin_right) /* || event_release(PS4_L3) && gvd || gvd1 */ && get_val(PS4_L2) && !get_val(PS4_R1) ) {
					 combo_stop(autospin_right);
        // gvd = FALSE;
      }

			
      if(event_release(PS4_L3) && gvd1 ) { // 
        combo_stop(autospin_right);
        gvd1 = FALSE;
      
      }

      if(event_release(PS4_R1) || event_release(PS4_LX) && gvd || gvd1 && !get_val(PS4_L3) && !get_val(PS4_R1) ) { // 
        // combo_stop(autospin_right);
        combo_stop(r1);
        pressonce = FALSE;
        gvd = FALSE;
        // gvd1 = FALSE;
        runfirst = FALSE;
      }