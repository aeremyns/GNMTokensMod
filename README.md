# GenderNeutralityTokenMod

List of currently available Tokens and their default values:
```
        Singular: false
        SubjectivePronoun : "They"
        ObjectivePronoun: "Them"
        PosessivePronoun: "Their"
        Title: "Mx."
        Adjective: "Gorgeous"
        SpouseNoun: "Partner"
        GenericNoun: "Person"
        AdultAntiquatedNoun: "Folk"
        AdultFamilialNoun: "Kid"
        AdultInformalNoun: "Person"
        ElderAntiquatedNoun: "Kid"
        ElderInformalNoun: "Kid"
        ElderFamilialNoun: "Child"
        ChildFamilialNoun: "Cousin"
        ServiceFormalNoun: "Esteemed Patron"
        TraderNoun: "Traveller"
        ParentalNoun: "Parent"
```

To use the tokens from this mod add this mod as a dependency to your content patcher mod.
All tokens are used in place of text with the prefix "Hana.GNMTokens/" (minus the quatation marks) and surrounded by the token markers

Example:

```
{{Hana.GNMTokens/SubjectivePronoun}}
```

The Singular token is a special case. To use this add a duplicate EditData entry in your content patcher file and add a "when" entry under it using: "Hana.GNMTokens/Singular": true

Example:

```json
{
        "Action": "EditData",
        "Entries":
                {
                        "Test": "They are cool."
                }
},
{
        "Action": "EditData",
        "Entries":
                {
                        "Test": "They is cool."
                }
        "When":
                {
                        "Hana.GNMTokens/Singular": true
                }
}
```

The above case would allow the user to see "They are cool" when the Singular variable is toggled off (the default) and "They is cool" when the Singular variable is toggled on.
