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
using Articy.Zombo.Features;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Articy.Zombo.Templates
{
    
    
    [Serializable()]
    public class DefaultSupportingCharacterTemplateTemplate : IArticyBaseObject, IPropertyProvider
    {
        
        [SerializeField()]
        private ArticyValueDefaultBasicCharacterFeatureFeature mDefaultBasicCharacterFeature = new ArticyValueDefaultBasicCharacterFeatureFeature();
        
        [SerializeField()]
        private UInt64 mOwnerId;
        
        [SerializeField()]
        private UInt32 mOwnerInstanceId;
        
        public Articy.Zombo.Features.DefaultBasicCharacterFeatureFeature DefaultBasicCharacterFeature
        {
            get
            {
                return mDefaultBasicCharacterFeature.GetValue();
            }
            set
            {
                mDefaultBasicCharacterFeature.SetValue(value);
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
                DefaultBasicCharacterFeature.OwnerId = value;
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
                DefaultBasicCharacterFeature.OwnerInstanceId = value;
            }
        }
        
        private void CloneProperties(object aClone, Articy.Unity.ArticyObject aFirstClassParent)
        {
            Articy.Zombo.Templates.DefaultSupportingCharacterTemplateTemplate newClone = ((Articy.Zombo.Templates.DefaultSupportingCharacterTemplateTemplate)(aClone));
            if ((DefaultBasicCharacterFeature != null))
            {
                newClone.DefaultBasicCharacterFeature = ((Articy.Zombo.Features.DefaultBasicCharacterFeatureFeature)(DefaultBasicCharacterFeature.CloneObject(newClone, aFirstClassParent)));
            }
            newClone.OwnerId = OwnerId;
        }
        
        public object CloneObject(object aParent, Articy.Unity.ArticyObject aFirstClassParent)
        {
            Articy.Zombo.Templates.DefaultSupportingCharacterTemplateTemplate clone = new Articy.Zombo.Templates.DefaultSupportingCharacterTemplateTemplate();
            CloneProperties(clone, aFirstClassParent);
            return clone;
        }
        
        #region property provider interface
        public void setProp(string aProperty, object aValue)
        {
            int featureIndex = aProperty.IndexOf('.');
            if ((featureIndex != -1))
            {
                string featurePath = aProperty.Substring(0, featureIndex);
                string featureProperty = aProperty.Substring((featureIndex + 1));
                if ((featurePath == "DefaultBasicCharacterFeature"))
                {
                    DefaultBasicCharacterFeature.setProp(featureProperty, aValue);
                }
            }
        }
        
        public Articy.Unity.Interfaces.ScriptDataProxy getProp(string aProperty)
        {
            int featureIndex = aProperty.IndexOf('.');
            if ((featureIndex != -1))
            {
                string featurePath = aProperty.Substring(0, featureIndex);
                string featureProperty = aProperty.Substring((featureIndex + 1));
                if ((featurePath == "DefaultBasicCharacterFeature"))
                {
                    return DefaultBasicCharacterFeature.getProp(featureProperty);
                }
            }
            return null;
        }
        #endregion
    }
}
