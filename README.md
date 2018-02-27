**Adjustable Character Spacing** -   
http://forum.unity3d.com/threads/adjustable-character-spacing-free-script.288277/   
free Unity script, was originally written by   
Chris Underwood (Deeperbeige)   
http://deeperbeige.com/
    
    Unity 5.4+ compatible version
    Produces an simple tracking/letter-spacing effect on UI Text components.
    Set the spacing parameter to adjust letter spacing.
     
    Negative values cuddle the text up tighter than normal. Go too far and it'll look odd.
    Positive values spread the text out more than normal. This will NOT respect the text area you've defined.
    Zero spacing will present the font with no changes.
    Relies on counting off characters in your Text component's text property and
    matching those against the quads passed in via the verts array. This is really
    rather primative, but I can't see any better way at the moment. It means that
    all sorts of things can break the effect...
     
    This component should be placed higher in component list than any other vertex
    modifiers that alter the total number of verticies. Eg, place this ABOVE Shadow
    or Outline effects. If you don't, the outline/shadow won't match the position
    of the letters properly. If you place the outline/shadow effect second however,
    it will just work on the altered vertices from this component, and function
    as expected.
     
    This component works best if you don't allow text to automatically wrap. It also
    blows up outside of the given text area. Basically, it's a cheap and dirty effect,
    not a clever text layout engine. It can't affect how Unity chooses to break up
    your lines. If you manually use line breaks however, it should detect those and
    function more or less as you'd expect.
     
    The spacing parameter is measured in pixels multiplied by the font size. This was
    chosen such that when you adjust the font size, it does not change the visual spacing
    that you've dialed in. There's also a scale factor of 1/100 in this number to
    bring it into a comfortable adjustable range. There's no limit on this parameter,
    but obviously some values will look quite strange.
     
    Now component works with RichText. You need to remember to turn on RichText via the checkbox
    (text.supportRichText) and turn on component's [useRichText] checkbox.
    