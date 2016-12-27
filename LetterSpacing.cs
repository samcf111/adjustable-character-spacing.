     
    #if UNITY_5_2
     
    publicoverridevoidModifyMesh (Meshmesh)
     
    {
     
    if (!this.IsActive ())
     
    return;
     
     
     
    List<UIVertex>list=newList<UIVertex> ();
     
    using (VertexHelpervertexHelper=newVertexHelper (mesh)) {
     
    vertexHelper.GetUIVertexStream (list);
     
    }
     
     
     
    this.ModifyVertices (list);  // calls the old ModifyVertices which was used on pre 5.2
     
     
     
    using (VertexHelpervertexHelper2=newVertexHelper ()) {
     
    vertexHelper2.AddUIVertexTriangleStream (list);
     
    vertexHelper2.FillMesh (mesh);
     
    }
     
    }
     
    #elif
     
    public override void ModifyMesh (VertexHelper vh)
     
    {
     
    if (!this.IsActive ())
     
    return;
     
     
     
    List<UIVertex> vertexList = new List<UIVertex> ();
     
    vh.GetUIVertexStream (vertexList);
     
     
     
    ModifyVertices (vertexList);
     
     
     
    vh.Clear ();
     
    vh.AddUIVertexTriangleStream (vertexList);
     
    }
     
    #endif
     
