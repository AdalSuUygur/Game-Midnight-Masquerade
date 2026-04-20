# 🎭 Midnight Masquerade

## GGJ Theme: Masks

**Our Interpretation:**
In *Midnight Masquerade*, we interpreted the theme through the duality of social classes. The "Mask" is not just a physical object but a mechanical key that dictates how the world perceives and reacts to the player. We focused on the tension between being "seen" and being "recognized."

This project was designed, prototyped, and documented within **48 hours**. Our goal was to create a cohesive stealth loop using a minimalist "Noir" aesthetic and a robust Finite State Machine for AI.

**"Identity is your greatest disguise."**
Midnight Masquerade is a top-down stealth-infiltration game developed for **Global Game Jam 2026**. Players take on the role of a master infiltrator who must navigate through high-society galas, servant quarters, and hedge mazes by strategically switching masks to blend into different social classes.

---

## Design Vision

The core inspiration comes from the **disguise mechanic in World of Warcraft: Legion**, where players could move freely among enemies while disguised, until entering the detection zone of a specific agent that would break the illusion. We wanted to translate that tension into a top-down stealth game:

- Move freely through a zone **as long as your mask matches the guards' class**
- The disguise holds until you enter an **agent's proximity detection zone**
- Once detected, the disguise breaks and guards become hostile

The full vision included a heist loop: infiltrate the estate, steal artifacts from each zone, and escape — all while managing your identity. Due to the 48-hour jam constraint, the project remains at prototype stage, with the core movement and architecture in place.

---

## Core Gameplay & Objectives

The ultimate goal is to infiltrate the estate and retrieve **three hidden artifacts**, one from each high-security zone, and reach the extraction point undetected.

* **Heist Objective:** Locate and collect the 3 Unique Artifacts (Noble Crest, Servant's Ledger, and The Golden Rose).
* **Identity Management:** Use the **Crimson (Noble)**, **Azure (Servant)**, or **Emerald (Gardener)** masks to access restricted zones. Swapping masks is only possible in "Safe Zones" (out of guard sight).
* **Stealth-First Infiltration:** There is no combat. Success depends on timing, line-of-sight manipulation, and environment awareness.
* **Dynamic Detection:** Suspicion levels rise based on your current mask and proximity to guards. A 100% suspicion level results in instant capture.

---

## Visual Direction (Noir Aesthetic)

* **Art Style:** High-contrast 64x64 Pixel Art.
* **Color Theory:** Low-saturation environments (Inky Blue, Anthracite) to make functional colors (Identity Masks) pop.
* **Lighting:** Heavy use of shadows and light cones to enhance the "Noir" atmosphere.
* **Tilesets:** AI-assisted pixel art generation, directed and curated for each zone (Grand Hall, Servant Quarters, Hedge Maze).

---

## Technical Stack

* **Engine:** Unity 6.0 (6000.0.66f2)
* **Language:** C#
* **Architecture:** Finite State Machine (FSM) for Guard AI — states: Patrol → Suspicion → Investigate → Chase → Search → Capture
* **Version Control:** Git-flow for collaborative development

---

## Documentation

Full design and technical documentation is available in the [`/Docs`](./Docs) folder:

* 📄 [Game Design Document (GDD)](./Docs/GDD.md) — Core mechanics, level design, identity system
* 🧠 [Guard AI FSM](./Docs/Guard_AI_FSM.md) — State machine logic with Mermaid diagram
* 🎨 [Visual Style Guide](./Docs/Visual_Asset_Inventory.md) — Color palette, art direction, sprite inventory
* ✅ [Asset Checklist](./Docs/Asset_Checklist.md) — Production tracking for all visual assets

---

## The Team

* **Adal** — Project Architect, Visual Systems Design (color palette, tileset direction & curation)
* **Çağatay** — Lead Designer & Narrative Architect
* **Miray** — Lead Programmer & Systems Engineer

---

## Project Structure

```
/Assets/_Project    → Core game content (Art, Scripts, Scenes)
/Docs               → Game Design Documents and Technical Specifications
/Docs/StyleGuide    → Color palettes and visual standards
```

---

*Developed during Global Game Jam 2026. Prototype stage — full heist loop in progress.*
