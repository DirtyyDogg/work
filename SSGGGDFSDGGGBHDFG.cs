// /*— ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌
			    // |                                                      unscope SHOT (8)                                                    |
			    // ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ —*/ 
			  	// // If DeadShot is enable for the curent profile
          // set_val(TRACE_2, unscopeend)
          //     set_val(TRACE_3, nowshoot)
          //     set_val(TRACE_4, unscopeint);
          //     set_val(TRACE_6, unscope)
					// if(unscope_on[profile_idx] == 1)
					// {
          //     set_val(TRACE_2, unscopeend)
          //     set_val(TRACE_3, nowshoot)
          //     set_val(TRACE_4, unscopeint);
          //     set_val(TRACE_6, unscope)
              
          //     if(get_val(PS4_R2) && !unscopeint){
          //       combo_run(DEADLY)
          //       unscopeint = 100;
          //       // deadeyeINIT = !deadeyeINIT;
          //     }

          //     if(unscopeint == 100 && get_val(PS4_R2)) {
          //       nowshoot = 999;
          //     }

          //     // if(deadeyeINIT = 1)	combo_run(DEADSHOT);

          //     // event_release(PS4_L2) && deadeyeINIT || deadeyeEND
          //     if(unscopeint&& !get_val(PS4_R2) && !get_val(PS4_L2) ) {if(nowshoot== 999) combo_run(DEADSHOTNU); combo_stop(DEADSHOT); unscope_on=FALSE; nowshoot=0; unscopeint=FALSE; }
          //     // if(deadeyeINIT =1 && !get_val(PS4_L2)) { combo_stop(DEADSHOT); deadeyeINIT=FALSE; deadeyeEND=FALSE; }
          //     // if(deadeyeINIT =1) { combo_stop(DEADSHOT); deadeyeINIT=0; deadeyeEND=0; }
          //     // deadeyeINIT = FALSE;
          //     // deadeyeEND=FALSE;
			    // 		// if(!deadeye && get_lval(PS4_L2) && event_press(PS4_R2)) 
			    // 		// if(get_val(PS4_L2) && !deadeyeEND ){

			    // }
          /*— ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌
			    |                                                      unscope SHOT (8)                                                    |
			    ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ —*/ 
			  	// If DeadShot is enable for the curent profile
          /*— ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌
			    |                                                      unscope SHOT (8)                                                    |
			    ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ —*/ 
          /* Auto unscoop mod  */
          if(pauw)  {
            /* goin in to scope  */
            if(!bScope & get_val(PS4_L2) && !event_press(PS4_DOWN) )  {  combo_run(cScope); }
        

            if(bScope&&get_val(PS4_L2) && get_val(PS4_R2) && !deadshotpenis) combo_run(cScopeIN);

            // if(event_release(PS4_L2)) { bScope}
          }

          // If DeadShot is enable for the curent profile
					// if(toggle_deadshot[profile_idx] == 1)
					// {
			    // 		if(!deadeye && get_lval(PS4_L2) && event_press(PS4_R2)) 
			    //     		combo_run(DEADSHOT);
			    // }


          
          
          
          
          
          
          
          
          
          
          
          
          
          
          
          
          
          /*— ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌
			    |                                                      unscope SHOT (8)                                                    |
			    ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ — ◌ —*/ 
			  	// If DeadShot is enable for the curent profile
          // set_val(TRACE_2, unscopeend)
          //     set_val(TRACE_3, nowshoot)
          //     set_val(TRACE_4, unscopeint);
          //     set_val(TRACE_6, unscope)
					// if(unscope_on[profile_idx] == 1)
					// {
          //     set_val(TRACE_2, unscopeend)
          //     set_val(TRACE_3, nowshoot)
          //     set_val(TRACE_4, unscopeint);
          //     set_val(TRACE_6, unscope)

          //     // if(toggle_rapidfire[profile_idx] != 5) toggle_rapidfire[profile_idx] = 5;
              
          //     if(get_val(PS4_R2) && !unscopeint){
          //       combo_run(DEADLY)
          //       unscopeint = 100;
          //       // deadeyeINIT = !deadeyeINIT;
          //     }

          //     if(unscopeint == 100 && get_val(PS4_R2)) {
          //       combo_run(UNSCOPE_shot);
          //       nowshoot = 999;

          //     }

          //     // if(deadeyeINIT = 1)	combo_run(DEADSHOT);

          //     // event_release(PS4_L2) && deadeyeINIT || deadeyeEND
          //     if(unscopeint&& !get_val(PS4_R2) && !get_val(PS4_L2) ) {if(nowshoot== 999) combo_run(UNSCOPE_shot); combo_stop(DEADSHOT); unscope_on=FALSE; nowshoot=0; unscopeint=FALSE; }
          //     // if(deadeyeINIT =1 && !get_val(PS4_L2)) { combo_stop(DEADSHOT); deadeyeINIT=FALSE; deadeyeEND=FALSE; }
          //     // if(deadeyeINIT =1) { combo_stop(DEADSHOT); deadeyeINIT=0; deadeyeEND=0; }
          //     // deadeyeINIT = FALSE;
          //     // deadeyeEND=FALSE;
			    // 		// if(!deadeye && get_lval(PS4_L2) && event_press(PS4_R2)) 
			    // 		// if(get_val(PS4_L2) && !deadeyeEND ){

			    // }