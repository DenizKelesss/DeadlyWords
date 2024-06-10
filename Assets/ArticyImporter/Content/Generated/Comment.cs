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
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Articy.Zombo
{
    
    
    public class Comment : ArticyObject, IComment, IPropertyProvider, IObjectWithColor, IObjectWithText, IObjectWithExternalId, IObjectWithShortId, IObjectWithPosition, IObjectWithZIndex, IObjectWithSize
    {
        
        [SerializeField()]
        private ArticyValueArticyString mCreatedBy = new ArticyValueArticyString();
        
        [SerializeField()]
        private DateTime mCreatedOn = new DateTime();
        
        [SerializeField()]
        private Color mColor;
        
        [SerializeField()]
        private ArticyValueArticyString mText = new ArticyValueArticyString();
        
        [SerializeField()]
        private String mExternalId;
        
        [SerializeField()]
        private Vector2 mPosition;
        
        [SerializeField()]
        private Single mZIndex;
        
        [SerializeField()]
        private Vector2 mSize;
        
        [SerializeField()]
        private UInt32 mShortId;
        
        public ArticyString CreatedBy
        {
            get
            {
                return mCreatedBy.GetValue();
            }
            set
            {
                mCreatedBy.SetValue(value);
            }
        }
        
        public DateTime CreatedOn
        {
            get
            {
                return mCreatedOn;
            }
            set
            {
                var oldValue = mCreatedOn;
                mCreatedOn = value;
                Articy.Unity.ArticyDatabase.ObjectNotifications.ReportChanged(Id, InstanceId, "CreatedOn", oldValue, mCreatedOn);
            }
        }
        
        public Color Color
        {
            get
            {
                return mColor;
            }
            set
            {
                var oldValue = mColor;
                mColor = value;
                Articy.Unity.ArticyDatabase.ObjectNotifications.ReportChanged(Id, InstanceId, "Color", oldValue, mColor);
            }
        }
        
        public ArticyString Text
        {
            get
            {
                return mText.GetValue();
            }
            set
            {
                mText.SetValue(value);
            }
        }
        
        public String ExternalId
        {
            get
            {
                return mExternalId;
            }
            set
            {
                var oldValue = mExternalId;
                mExternalId = value;
                Articy.Unity.ArticyDatabase.ObjectNotifications.ReportChanged(Id, InstanceId, "ExternalId", oldValue, mExternalId);
            }
        }
        
        public Vector2 Position
        {
            get
            {
                return mPosition;
            }
            set
            {
                var oldValue = mPosition;
                mPosition = value;
                Articy.Unity.ArticyDatabase.ObjectNotifications.ReportChanged(Id, InstanceId, "Position", oldValue, mPosition);
            }
        }
        
        public Single ZIndex
        {
            get
            {
                return mZIndex;
            }
            set
            {
                var oldValue = mZIndex;
                mZIndex = value;
                Articy.Unity.ArticyDatabase.ObjectNotifications.ReportChanged(Id, InstanceId, "ZIndex", oldValue, mZIndex);
            }
        }
        
        public Vector2 Size
        {
            get
            {
                return mSize;
            }
            set
            {
                var oldValue = mSize;
                mSize = value;
                Articy.Unity.ArticyDatabase.ObjectNotifications.ReportChanged(Id, InstanceId, "Size", oldValue, mSize);
            }
        }
        
        public UInt32 ShortId
        {
            get
            {
                return mShortId;
            }
            set
            {
                var oldValue = mShortId;
                mShortId = value;
                Articy.Unity.ArticyDatabase.ObjectNotifications.ReportChanged(Id, InstanceId, "ShortId", oldValue, mShortId);
            }
        }
        
        protected override void CloneProperties(object aClone, Articy.Unity.ArticyObject aFirstClassParent)
        {
            Comment newClone = ((Comment)(aClone));
            if ((mCreatedBy != null))
            {
                newClone.mCreatedBy = ((ArticyValueArticyString)(mCreatedBy.CloneObject(newClone, aFirstClassParent)));
            }
            newClone.CreatedOn = CreatedOn;
            newClone.Color = Color;
            if ((mText != null))
            {
                newClone.mText = ((ArticyValueArticyString)(mText.CloneObject(newClone, aFirstClassParent)));
            }
            newClone.ExternalId = ExternalId;
            newClone.Position = Position;
            newClone.ZIndex = ZIndex;
            newClone.Size = Size;
            newClone.ShortId = ShortId;
            base.CloneProperties(newClone, aFirstClassParent);
        }
        
        #region property provider interface
        public override void setProp(string aProperty, object aValue)
        {
            if ((aProperty == "CreatedBy"))
            {
                CreatedBy = System.Convert.ToString(aValue);
                return;
            }
            if ((aProperty == "CreatedOn"))
            {
                CreatedOn = ((DateTime)(aValue));
                return;
            }
            if ((aProperty == "Color"))
            {
                Color = ((Color)(aValue));
                return;
            }
            if ((aProperty == "Text"))
            {
                Text = System.Convert.ToString(aValue);
                return;
            }
            if ((aProperty == "ExternalId"))
            {
                ExternalId = System.Convert.ToString(aValue);
                return;
            }
            if ((aProperty == "Position"))
            {
                Position = ((Vector2)(aValue));
                return;
            }
            if ((aProperty == "ZIndex"))
            {
                ZIndex = System.Convert.ToSingle(aValue);
                return;
            }
            if ((aProperty == "Size"))
            {
                Size = ((Vector2)(aValue));
                return;
            }
            if ((aProperty == "ShortId"))
            {
                ShortId = ((UInt32)(aValue));
                return;
            }
            base.setProp(aProperty, aValue);
        }
        
        public override Articy.Unity.Interfaces.ScriptDataProxy getProp(string aProperty)
        {
            if ((aProperty == "CreatedBy"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(CreatedBy);
            }
            if ((aProperty == "CreatedOn"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(CreatedOn);
            }
            if ((aProperty == "Color"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(Color);
            }
            if ((aProperty == "Text"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(Text);
            }
            if ((aProperty == "ExternalId"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(ExternalId);
            }
            if ((aProperty == "Position"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(Position);
            }
            if ((aProperty == "ZIndex"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(ZIndex);
            }
            if ((aProperty == "Size"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(Size);
            }
            if ((aProperty == "ShortId"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(ShortId);
            }
            return base.getProp(aProperty);
        }
        #endregion
    }
}
