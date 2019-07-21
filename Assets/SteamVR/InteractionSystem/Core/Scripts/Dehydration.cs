//======= Copyright (c) Valve Corporation, All rights reserved. ===============
//
// Purpose: Collider dangling from the player's head
//
//=============================================================================

using UnityEngine;
using System.Collections;


namespace Valve.VR.InteractionSystem
{
	//-------------------------------------------------------------------------
	[RequireComponent( typeof( CapsuleCollider ) )]
	public class Dehydration : MonoBehaviour
	{
        ParticleSystem.EmissionModule emission;
        ParticleSystem.MainModule main; 
        public float max_hydration = 100;
        private float current_hydration;

        

        //-------------------------------------------------
        void Awake()
		{
			
		}

        void Start()
        {
            ParticleSystem ps = GetComponent<ParticleSystem>();
            emission = ps.emission;


            current_hydration = max_hydration;
            var main = ps.main;
            

            //main.startDelay = 5.0f;
            //main.startLifetime = 2.0f;

            
        }
        //sets emission rate of smoke effect
       /* void setEmissionVal(float val)
        {
            emission.rateOverTime = val; //arbitrary, start out

        }

        float getEmissionVal()
        {
            return emission.rateOverTime.constant;
        }*/
        private void Update()
        {
            //as time goes on hydration decreases
            current_hydration -= 10;
            Debug.Log("This is current hydration: " + current_hydration);
            
        }

	}
}
