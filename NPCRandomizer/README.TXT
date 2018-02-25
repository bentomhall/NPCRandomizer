This app uses a selection of JSON-format files as the source of the names and cultures. This file explains the format of each file. In practice, npc_names.json, races.json, and nations.json are the main ones to change.

Data Types:
NamedRange: //represents a percentile range for weighted random selection
{
    "Name": string,
    "Start": float // 0 < x <= 1.0
    "Stop": float // Start < x <= 1.0
}

File: npc_names.json
Format:
[
    {
        "Culture": string //this is the internal name for the culture that uses the names in this element.
        "Male": [string] //this is a list of masculine given names. Currently this is used as the default for non-binary genders as well.
        "Female": [string] //this is a list of feminine given names. Can be the same as the male list (for non-gendered names).
        "Combiner": string //this is a string that goes between the given name and the family name (separated by spaces).
        "Family": [string] //a list of family names. Can be empty for mono-name cultures.
        "Base": string //currently unused, this holds the base RL language used as the source of names. 
    },
    ...
]

File: races.json
Format:
[
    {
        "Race": string //the name of the race
        "Nation": string //the name of the nation (nation + race must be unique, nation must match entries in nations.json, case sensitive)
        "Culture": string //the culture to pull names from for this combination of race and nation. Must have an entry in npc_names.json
        "Gender": [NamedRange] //mandatory values are male and female; others can be included. This sets gender balance for that race/nation combination.
        "Religiosity": [string] //list of choices for religious observance. Currently equally weighted.
        "Subrace": [NamedRange] //list of subraces--this can be used for PHB subraces or for variants within a race that share naming conventions (such as my tieflings, aasimar, and genasi).
    },
    ...
]

File: nations.json
Format:
[
    {
        "Name": string //name of the nation, must match (including case) to races.json
        "Races": [NamedRange] //list of race elements with prevalence weighting.
    }
]

File: personality.json
Format
[string] //adjectives for personality traits. Currently assigned randomly.

File professions.json
Format:
[string] //a list of medieval professions (with a few fantasy additions). Currently assigned randomly.