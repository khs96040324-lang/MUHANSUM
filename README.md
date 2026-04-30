# Love & Choices

## 1. Project Overview
**Genre:** 2D Dating Simulation  
**Project Type:** Individual Project  

**One-line Description:**  
A 2D dating simulation where the player interacts with diverse characters and develops relationships through choices.

---

## 2. Core Gameplay
- **Player Goal:** Increase affection points through dialogue and events, and reach an ending with a chosen character.  
- **Core Fun:**  
  - Story-driven choices  
  - Building relationships with characters  
  - Collecting multiple endings  

---

## 3. Player Actions
- Choose dialogue options  
- Participate in events  
- Give gifts  
- Manage schedules  

---

## 4. Game Rules
- Choices affect affection positively or negatively  
- Certain event conditions must be met to progress the story  
- Endings trigger when affection reaches a threshold  

---

## 5. Key Elements
- **Main Characters:** Romance targets  
- **Events:** Dates, special scenarios  
- **Affection System:** Tracks relationship progress  
- **Items:** Gifts to influence affection  

---

## 6. Clear/Fail Conditions
- **Clear:** Achieve an ending event with a character  
- **Fail:** No ending triggered due to low affection with all characters  

---

## 7. Essential Features
- Dialogue choice system  
- Affection management  
- Event triggering and condition checks  
- Ending branching logic  
- UI display (affection gauge, event log, ending screen)  

---

## 8. Data Structures Usage
- **Array:** Store affection points for each character (`int[] affectionPoints`)  
- **List:** Track event history experienced by the player  
- **Dictionary:** Map character IDs to names, images, and dialogue lines  
- **Stack:** Save dialogue choice history for undo functionality  
- **Queue:** Handle sequential events and notifications  

---

## 9. UI Elements
- Character affection gauge  
- Current event log  
- Dialogue choice interface  
- Ending screen  

---

## 10. Development Priorities
- **First:** Dialogue system, affection system, basic event triggers  
- **Later (if time allows):** Undo feature (Stack), event queue processing, multi-ending branching  

---

## 11. Completion Goal
A full game loop:  
**Start → Dialogue & Event Choices → Affection Changes → Ending Trigger**  
The project is considered complete when this flow works seamlessly.

---
