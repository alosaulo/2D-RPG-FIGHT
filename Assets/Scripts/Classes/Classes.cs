using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class Classes
{
   public string ClassName;
   public string ClassDescription;
   public List<Skills> skills = new List<Skills>();

   protected virtual void SetSkills(){}
}
