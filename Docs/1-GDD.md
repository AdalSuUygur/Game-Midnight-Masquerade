# 🎭 Game Design Document: Midnight Masquerade

## 1. Project Overview

* **Genre:** Top-Down Stealth / Infiltration
* **Theme:** Identity is your greatest disguise.
* **Platform:** PC / Android (Unity 6.0)
* **Core Loop:** Infiltrate → Choose Identity → Avoid Suspicion → Steal Artifact → Escape

---

## 2. Gameplay Objectives

Retrieve **three unique artifacts** without being captured:
1. **The Noble Crest** (Grand Hall)
2. **The Servant's Ledger** (Servant Quarters)
3. **The Golden Rose** (Hedge Maze)

---

## 3. Core Mechanics

### 🎭 Identity & Mask System
| Mask | Safe Zone | Risk Zones |
| :--- | :--- | :--- |
| **Crimson (Noble)** | Grand Hall | Quarters / Garden |
| **Azure (Servant)** | Servant Quarters | Hall / Garden |
| **Emerald (Gardener)** | Hedge Maze | Hall / Quarters |

* **Swap Rule:** Mask swapping is only possible in **Safe Zones** (areas with no guard vision cone overlap).
* **Design Inspiration:** Based on the disguise mechanic from *World of Warcraft: Legion* expension where the player moves freely among enemies until entering a specific agent's proximity detection zone, which breaks the disguise.

### 👁️ Detection & Suspicion System
* **Vision Cones:** Guards have active 2D vision cones (Raycast2D).
* **Suspicion Meter:** Fills when entering a vision cone; speed depends on identity match.
  * Matching Mask: +5% suspicion/sec
  * Mismatched Mask: +25% suspicion/sec
  * No Mask: Instant chase
* **Suspicion Decay:** -10% per sec when out of sight.
* **Capture:** 100% suspicion or direct contact results in instant capture.

### 🏃 Guard AI (Finite State Machine)
States: **Patrol → Suspicion → Investigate → Chase → Search → Capture**

See full FSM documentation: [`/Docs/Guard_AI_FSM.md`](./Guard_AI_FSM.md)

---

## 4. Level Design (Zones)

| Zone | Identity | Design Focus |
| :--- | :--- | :--- |
| **Grand Hall** | Noble | Open space, long sightlines |
| **Servant Quarters** | Servant | Tight corridors, blind corners |
| **Hedge Maze** | Gardener | Obstructed vision, multiple paths |

---

## 5. Visual & Asset Specifications

* **Resolution:** 64x64 px (Tiles & Characters)
* **Filter Mode:** Point (No Compression)
* **Camera:** Fixed top-down with slight movement smoothing.
* **Tilesets:** AI-assisted pixel art, directed and curated per zone.

See full asset inventory: [`/Docs/Visual_Asset_Inventory.md`](./Visual_Asset_Inventory.md)

---

## 6. Current Build Status

| Feature | Status | Notes |
| :--- | :--- | :--- |
| Core movement (WASD) | ✅ Complete | 4-way movement working |
| Scene / level layout | ⏳ Pending | Zone structure designed |
| Mask system | ⏳ Pending | Logic designed, not implemented |
| Guard AI (FSM) | ⏳ Pending | Architecture documented |
| Detection / suspicion meter | ⏳ Pending | Values defined in FSM doc |
| Artifact collection | ⏳ Pending | Objects defined in GDD |
| Win / lose conditions | ⏳ Pending | — |
| UI (HUD) | ⏳ Pending | Designed in asset checklist |

---

### 🗓️ Week 1 — Core Loop

**Goal:** A playable single-zone prototype with detection and one artifact.

| Day | Task | Est. Time |
| :--- | :--- | :--- |
| Day 1 | Scene setup: import tilesets, build Grand Hall layout | 2 hrs |
| Day 2 | Guard prefab: patrol waypoints + basic movement | 2 hrs |
| Day 3 | Vision cone implementation (Raycast2D, field of view) | 2 hrs |
| Day 4 | Suspicion meter: UI bar + fill logic based on mask match | 2 hrs |
| Day 5 | Mask system: equip/unequip, safe zone trigger | 2 hrs |
| Day 6 | Artifact pickup: interaction trigger + win condition | 2 hrs |
| Day 7 | Buffer / bug fixing / playtesting Week 1 build | 2 hrs |

**Week 1 Deliverable:** Player can enter Grand Hall, equip Noble mask, avoid one guard, steal one artifact, and reach the exit.

---

### 🗓️ Week 2 — Polish & Ship

**Goal:** Full three-zone experience, lose condition, basic UI, itch.io build.

| Day | Task | Est. Time |
| :--- | :--- | :--- |
| Day 8 | FSM complete: Investigate + Chase + Search states | 2 hrs |
| Day 9 | Add Servant Quarters zone + Azure mask logic | 2 hrs |
| Day 10 | Add Hedge Maze zone + Emerald mask logic | 2 hrs |
| Day 11 | Lose condition: capture screen + restart | 2 hrs |
| Day 12 | HUD: active mask display + suspicion bar polish | 2 hrs |
| Day 13 | Full playthrough test: all 3 zones, all 3 artifacts | 2 hrs |
| Day 14 | Build export (PC + Android) + itch.io upload | 2 hrs |

**Week 2 Deliverable:** Complete heist loop across all three zones. Playable build live on itch.io.

---

*GGJ 2026 Prototype — active development.*
