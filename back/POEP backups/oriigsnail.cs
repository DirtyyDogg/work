/*— ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌
			    |                                                      DEAD SHOT (8)                                                    |
			    ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ —*/ 
			  	// If DeadShot is enable for the curent profile
          set_val(TRACE_2, deadeyeEND)
              set_val(TRACE_3, nowshoot)
              set_val(TRACE_4, testmemo);
              set_val(TRACE_6, deadeyeINIT)
					if(toggle_deadshot[profile_idx] == 1)
					{
              set_val(TRACE_2, deadeyeEND);
              set_val(TRACE_3, nowshoot);
              set_val(TRACE_4, testmemo);
              set_val(TRACE_6, deadeyeINIT);
              
              if(get_val(PS4_R2) && !deadeyeINIT){
                combo_run(DEADLY)
                deadeyeEND = 100;
                // deadeyeINIT = !deadeyeINIT;
              }

              // if(deadeyeINIT = 1)	combo_run(DEADSHOT);

              // event_release(PS4_L2) && deadeyeINIT || deadeyeEND
              if(deadeyeINIT&& !get_val(PS4_R2) && !get_val(PS4_L2) ) {if(nowshoot== 999) combo_stop(DEADSHOT); combo_stop(DEADSHOT); deadeyeINIT=FALSE; deadeyeEND=FALSE; }
              // if(deadeyeINIT =1 && !get_val(PS4_L2)) { combo_stop(DEADSHOT); deadeyeINIT=FALSE; deadeyeEND=FALSE; }
              // if(deadeyeINIT =1) { combo_stop(DEADSHOT); deadeyeINIT=0; deadeyeEND=0; }
              // deadeyeINIT = FALSE;
              // deadeyeEND=FALSE;
			    		// if(!deadeye && get_lval(PS4_L2) && event_press(PS4_R2)) 
			    		// if(get_val(PS4_L2) && !deadeyeEND ){

			    }