// (c) Copyright HutongGames, LLC 2010-2014. All rights reserved.

using UnityEngine;
using System;

namespace HutongGames.PlayMaker.Actions
{
	
	[ActionCategory(ActionCategory.Array)]
	[Tooltip("Add multiple items to the end of an array.\nNOTE: There is a bug in this action when resizing Variables. It will be fixed in the next update.")]
	public class ArrayAddRange2 : FsmStateAction
	{
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The Array Variable to use.")]
		public FsmArray array;

        [RequiredField]
        public FsmGameObject AD;
        [RequiredField]
        public FsmGameObject MY;
        [RequiredField]
        public FsmGameObject MS;
        [RequiredField]
        public FsmGameObject CN;

        public FsmInt bigMin;

        public FsmFloat Lad;
        public FsmFloat Lmy;
        public FsmFloat Lms;
        public FsmFloat Lcn;


        public override void Reset()
		{
			array = null;

            AD = null;
			MY = null;
			MS = null;
			CN = null;

            bigMin = 20;
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
			
			FsmBool big = false;
			int ADi = Array.IndexOf(array.Values, AD.Value);	
			int MYi = Array.IndexOf(array.Values, MY.Value);
			int MSi = Array.IndexOf(array.Values, MS.Value);
			int CNi = Array.IndexOf(array.Values, CN.Value);
			

			//if (ADi < 0) 
			//{ if (LadAbs.Value >= bigMin.Value) //big
            // {
            //     array.Resize(array.Length + 1);
			//	array.Set(array.Length - 1, AD.Value);
            // } else if (AD < 0) {
	        //     if (LadAbs.Value > 0) //small
	        //     {
	        //         array.Resize(array.Length + 1);
		    //         array.Set(array.Length - 1, AD_small.Value);}}}
	             
			
			//if (LadAbs.Value >= bigMin.Value)
			//{
			//	array.Resize(array.Length + 1);
			//	array.Set(array.Length - 1, AD.Value);
			//} else if (LadAbs.Value > 0)
			//  {
			//	if (ADi < 0)
			//  }
			
			//switch (true)
			//{
			//case (ADi > 20):
			//	break;
			//}
			
          

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
