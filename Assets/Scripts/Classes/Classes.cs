using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public abstract class Classes {
   public List<Skills> skills = new List<Skills>();
   protected abstract void SetSkills();
   public string ClassDescription;
}
