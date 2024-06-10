//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Articy.Unity;
using Articy.Unity.Interfaces;
using Articy.Zombo;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Articy.Zombo.Features
{
    
    
    [Serializable()]
    public class DefaultExtendedCharacterFeatureFeature : IArticyBaseObject, IPropertyProvider
    {
        
        [SerializeField()]
        private ArticyValueArticyMultiLanguageString mMotivation = new ArticyValueArticyMultiLanguageString();
        
        [SerializeField()]
        private ArticyValueArticyMultiLanguageString mInnerConflict = new ArticyValueArticyMultiLanguageString();
        
        [SerializeField()]
        private ArticyValueArticyMultiLanguageString mSkills = new ArticyValueArticyMultiLanguageString();
        
        [SerializeField()]
        private ArticyValueArticyMultiLanguageString mFears = new ArticyValueArticyMultiLanguageString();
        
        [SerializeField()]
        private ArticyValueArticyMultiLanguageString mHabits = new ArticyValueArticyMultiLanguageString();
        
        [SerializeField()]
        private ArticyValueArticyMultiLanguageString mFurtherDetails = new ArticyValueArticyMultiLanguageString();
        
        [SerializeField()]
        private UInt64 mOwnerId;
        
        [SerializeField()]
        private UInt32 mOwnerInstanceId;
        
        public ArticyMultiLanguageString Motivation
        {
            get
            {
                return mMotivation.GetValue();
            }
            set
            {
                mMotivation.SetValue(value);
            }
        }
        
        public ArticyMultiLanguageString InnerConflict
        {
            get
            {
                return mInnerConflict.GetValue();
            }
            set
            {
                mInnerConflict.SetValue(value);
            }
        }
        
        public ArticyMultiLanguageString Skills
        {
            get
            {
                return mSkills.GetValue();
            }
            set
            {
                mSkills.SetValue(value);
            }
        }
        
        public ArticyMultiLanguageString Fears
        {
            get
            {
                return mFears.GetValue();
            }
            set
            {
                mFears.SetValue(value);
            }
        }
        
        public ArticyMultiLanguageString Habits
        {
            get
            {
                return mHabits.GetValue();
            }
            set
            {
                mHabits.SetValue(value);
            }
        }
        
        public ArticyMultiLanguageString FurtherDetails
        {
            get
            {
                return mFurtherDetails.GetValue();
            }
            set
            {
                mFurtherDetails.SetValue(value);
            }
        }
        
        public UInt64 OwnerId
        {
            get
            {
                return mOwnerId;
            }
            set
            {
                mOwnerId = value;
            }
        }
        
        public UInt32 OwnerInstanceId
        {
            get
            {
                return mOwnerInstanceId;
            }
            set
            {
                mOwnerInstanceId = value;
            }
        }
        
        private void CloneProperties(object aClone, Articy.Unity.ArticyObject aFirstClassParent)
        {
            Articy.Zombo.Features.DefaultExtendedCharacterFeatureFeature newClone = ((Articy.Zombo.Features.DefaultExtendedCharacterFeatureFeature)(aClone));
            if ((mMotivation != null))
            {
                newClone.mMotivation = ((ArticyValueArticyMultiLanguageString)(mMotivation.CloneObject(newClone, aFirstClassParent)));
            }
            if ((mInnerConflict != null))
            {
                newClone.mInnerConflict = ((ArticyValueArticyMultiLanguageString)(mInnerConflict.CloneObject(newClone, aFirstClassParent)));
            }
            if ((mSkills != null))
            {
                newClone.mSkills = ((ArticyValueArticyMultiLanguageString)(mSkills.CloneObject(newClone, aFirstClassParent)));
            }
            if ((mFears != null))
            {
                newClone.mFears = ((ArticyValueArticyMultiLanguageString)(mFears.CloneObject(newClone, aFirstClassParent)));
            }
            if ((mHabits != null))
            {
                newClone.mHabits = ((ArticyValueArticyMultiLanguageString)(mHabits.CloneObject(newClone, aFirstClassParent)));
            }
            if ((mFurtherDetails != null))
            {
                newClone.mFurtherDetails = ((ArticyValueArticyMultiLanguageString)(mFurtherDetails.CloneObject(newClone, aFirstClassParent)));
            }
            newClone.OwnerId = OwnerId;
        }
        
        public object CloneObject(object aParent, Articy.Unity.ArticyObject aFirstClassParent)
        {
            Articy.Zombo.Features.DefaultExtendedCharacterFeatureFeature clone = new Articy.Zombo.Features.DefaultExtendedCharacterFeatureFeature();
            CloneProperties(clone, aFirstClassParent);
            return clone;
        }
        
        #region property provider interface
        public void setProp(string aProperty, object aValue)
        {
            if ((aProperty == "Motivation"))
            {
                Motivation = System.Convert.ToString(aValue);
                return;
            }
            if ((aProperty == "InnerConflict"))
            {
                InnerConflict = System.Convert.ToString(aValue);
                return;
            }
            if ((aProperty == "Skills"))
            {
                Skills = System.Convert.ToString(aValue);
                return;
            }
            if ((aProperty == "Fears"))
            {
                Fears = System.Convert.ToString(aValue);
                return;
            }
            if ((aProperty == "Habits"))
            {
                Habits = System.Convert.ToString(aValue);
                return;
            }
            if ((aProperty == "FurtherDetails"))
            {
                FurtherDetails = System.Convert.ToString(aValue);
                return;
            }
        }
        
        public Articy.Unity.Interfaces.ScriptDataProxy getProp(string aProperty)
        {
            if ((aProperty == "Motivation"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(Motivation);
            }
            if ((aProperty == "InnerConflict"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(InnerConflict);
            }
            if ((aProperty == "Skills"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(Skills);
            }
            if ((aProperty == "Fears"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(Fears);
            }
            if ((aProperty == "Habits"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(Habits);
            }
            if ((aProperty == "FurtherDetails"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(FurtherDetails);
            }
            return null;
        }
        #endregion
    }
}
