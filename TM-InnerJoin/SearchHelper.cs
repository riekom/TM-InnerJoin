using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sdl.LanguagePlatform.TranslationMemoryApi;
using Sdl.LanguagePlatform.TranslationMemory;
using Sdl.LanguagePlatform.Core;
using Sdl.Core.Globalization;

namespace TM_InnerJoin
{
    class SearchHelper
    {
        /*
         * Assumptions:
         * 1. Both chosen TMs must have 1 language in common.
         * 2. One of the 2 distinct languages must be the Project Source language.
         * 3. The other distinct language must be the Project Target language.
         * Start out with doing source>target searching only from Trados Studio (possibly add target concordance later?)
         * It might make things easier if we can make a wrapper class for both server-based and file-based
         * TMs so we can just pass them to our functions below and run a search without having to differentiate.
        */


        //*********************************************
        
        //class variables
        //TranslationOptions options;

        //This class needs access to at least the project source lang and project target lang
        //it may also need the other info for connecting to the TMs
        //public SearchHelper([language pair object or just a pair of strings and TranslationOptions])
        //{
        //  set variables for project language pair and TranslationOptions
        //  options = [parameter passed] //see TranslationOptions for the values it holds...plus we can put whatever we need in it if not already there
        //}

        //make a public method to take the two tms and call private methods based on different scenarios
        //public string Search(tm1, tm2, string searchString)
        //{
            //TODO: need to determine:
            //1.a. which TM has the project source language? (TM_ps = tm1 or tm2?)
            //  b. is project source lang the source (TM_ps_S) or target lang (TM_ps_T) of this TM?
            //2.a. The other TM must have our project target language (TM_pt).
            //  b. is project target lang the source (TM_pt_S) or target (TM_pt_T) lang of this other TM?
            //3. Call methods below based on the following:
                 //Start with TM_ps.
                 //IF: TM_ps_S
                 //|     |-->IF:   TM_pt_S --> Scenario 1.
                 //|     |-->ELSE: (TM_pt_T)-> Scenario 3.
                 //|
                 //ELSE: (TM_ps_T)
                 //      |-->IF:   TM_pt_S --> Scenario 4.
                 //      |-->ELSE: (TM_pt_T)-> Scenario 2.
          //}   
        
        
        //TODO: different search methods needed...
        
        //Scenario 1: (1 TM is project source lang (PS) > common lang (CL), the other is project target (PT) to common lang (CL))
        //(Regular search then target concordance)
        //private string Scenario1(TM_ps_S, TM_pt_S, string searchString)
            //{
            //1. Search for PS text in TM where PS is source lang
            //2. If exists get value for CL target
            //3. Do target concordance for CL (from step 2) in the other TM.
            //4. If exists get PT from source in other TM
            //Return PT
        //}

        //Scenario 2: (1 TM is common lang (CL) > project source lang (PS), the other is common lang (CL) > project target (PT))
        //(Target concordance then regular search)
        //private string Scenario2(TM_ps_T, TM_pt_T, string searchString)
        //{
            //1. Target concordance for PS text in TM where PS is target lang
            //2. If exists get value for CL source
            //3. Search for CL (from step 2) in the source of the other TM.
            //4. If exists get PT from target in other TM
            //Return PT
        //}
        
        //Scenario 3: (1 TM is project source lang (PS) > common lang (CL), the other is common lang (CL) > project target (PT))
        //(Regular search then regular search)
        //private string Scenario3(TM_ps_S, TM_pt_T, string searchString)
        //{
            //1. Search for PS text in TM where PS is source lang
            //2. If exists get value for CL target
            //3. Search for CL (from step 2) in the source of the other TM.
            //4. If exists get PT from target in other TM
            //Return PT
        //}

        //Scenario 4: (1 TM is common lang (CL) > project source lang (PS), the other is project target (PT) to common lang (CL))
        //(Target concordance then target concordance)
        //private string Scenario4(TM_ps_T, TM_pt_S, string searchString)
        //{
            //1. Target concordance for PS text in TM where PS is target lang
            //2. If exists get value for CL source
            //3. Target concordance for CL (from step 2) in the other TM.
            //4. If exists get PT from source in other TM
            //Return PT
        //}
    }
}
