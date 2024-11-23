// (c) Copyright HutongGames, LLC 2010-2014. All rights reserved.

using UnityEngine;
using System;

namespace HutongGames.PlayMaker.Actions
{
	
	[ActionCategory(ActionCategory.Array)]
	[Tooltip("Add multiple items to the end of an array.\nNOTE: There is a bug in this action when resizing Variables. It will be fixed in the next update.")]
	public class ArrayAddRange1 : FsmStateAction
	{
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The Array Variable to use.")]
		public FsmArray array;
		
		[RequiredField]
		[MatchElementType("array")]
		[Tooltip("The items to add to the array.")]
		public FsmVar[] variables;

        [RequiredField]
        public FsmGameObject AD_big;
        [RequiredField]
        public FsmGameObject AD_small;
        [RequiredField]
        public FsmGameObject MY_big;
        [RequiredField]
        public FsmGameObject MY_small;
        [RequiredField]
        public FsmGameObject MS_big;
        [RequiredField]
        public FsmGameObject MS_small;
        [RequiredField]
        public FsmGameObject CN_big;
        [RequiredField]
        public FsmGameObject CN_small;

        public FsmInt bigMin;

        public FsmFloat Lad;
        public FsmFloat Lmy;
        public FsmFloat Lms;
        public FsmFloat Lcn;


        public override void Reset()
		{
			array = null;
			variables = new FsmVar[2];

            AD_big = null;
			AD_small = null;
			MY_big = null;
			MY_small = null;
			MS_big = null;
			MS_small = null;
			CN_big = null;
			CN_small = null;

            bigMin = 20;
            Lad = 0;
    }

		public override void OnEnter()
		{
			
			DoAddRange();
		
			Finish();
		}
		
		private void DoAddRange()
		{
			FsmFloat LadAbs = Mathf.Abs(Lad.Value);
            FsmFloat LmyAbs = Mathf.Abs(Lmy.Value);
            FsmFloat LmsAbs = Mathf.Abs(Lms.Value);
			FsmFloat LcnAbs = Mathf.Abs(Lcn.Value);
			
            
			int AD_bigI = Array.IndexOf(array.Values, AD_big.Value); 
			int AD_smallI = Array.IndexOf(array.Values, AD_small.Value); 
			
			int MY_bigI = Array.IndexOf(array.Values, MY_big.Value); 
			int MY_smallI = Array.IndexOf(array.Values, MY_small.Value); 
			
			int MS_bigI = Array.IndexOf(array.Values, MS_big.Value); 
			int MS_smallI = Array.IndexOf(array.Values, MS_small.Value); 
			
			int CN_bigI = Array.IndexOf(array.Values, CN_big.Value); 
			int CN_smallI = Array.IndexOf(array.Values, CN_small.Value); 
			
			

			if (AD_bigI < 0) 
			{ if (LadAbs.Value >= bigMin.Value) //big
             {
                 array.Resize(array.Length + 1);
				array.Set(array.Length - 1, AD_big.Value);
             } else if (AD_smallI < 0) {
	             if (LadAbs.Value > 0) //small
	             {
	                 array.Resize(array.Length + 1);
		             array.Set(array.Length - 1, AD_small.Value);}}}
	             
	             
			if (MY_bigI < 0) 
			{ if (LmyAbs.Value >= bigMin.Value) //big
			{
				array.Resize(array.Length + 1);
				array.Set(array.Length - 1, MY_big.Value);
			} else if (MY_smallI < 0) {
				if (LmyAbs.Value > 0) //small
				{
					array.Resize(array.Length + 1);
					array.Set(array.Length - 1, MY_small.Value);}}}
					
					
			if (MS_bigI < 0) 
			{ if (LmsAbs.Value >= bigMin.Value) //big
			{
				array.Resize(array.Length + 1);
				array.Set(array.Length - 1, MS_big.Value);
			} else if (MS_smallI < 0) {
				if (LmsAbs.Value > 0) //small
				{
					array.Resize(array.Length + 1);
					array.Set(array.Length - 1, MS_small.Value);}}}
					
					
			if (CN_bigI < 0) 
			{ if (LcnAbs.Value >= bigMin.Value) //big
			{
				array.Resize(array.Length + 1);
				array.Set(array.Length - 1, CN_big.Value);
			} else if (CN_smallI < 0) {
				if (LcnAbs.Value > 0) //small
				{
					array.Resize(array.Length + 1);
					array.Set(array.Length - 1, CN_small.Value);}}}
			
			
          

            /*int count = variables.Length;

			if (count > 0)
			{
				array.Resize(array.Length + count);

				foreach (FsmVar _var in variables)
				{
					_var.UpdateValue();
					array.Set(array.Length - count, _var.GetValue());
					count--;
				}
			}*/

        }
		
		
	}
}
