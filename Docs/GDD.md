# 🎭 Game Design Document: Midnight Masquerade

## 1. Project Overview

* **Genre:** Top-Down Stealth / Infiltration
* **Theme:** Identity is your greatest disguise.
* **Platform:** PC / Mobile (Unity)
* **Core Loop:** Infiltrate -> Choose Identity -> Avoid Suspicion -> Steal Artifact -> Escape

## 2. Gameplay Objectives

Retrieve **three unique artifacts** without being captured:
1. **The Noble Crest** (Grand Hall)
2. **The Servant’s Ledger** (Servant Quarters)
3. **The Golden Rose** (Hedge Maze)

## 3. Core Mechanics

### 🎭 Identity & Mask System
| Mask | Safe Zone | Risk Zones |
| :--- | :--- | :--- |
| **Crimson (Noble)** | Grand Hall | Quarters / Garden |
| **Azure (Servant)** | Servant Quarters | Hall / Garden |
| **Emerald (Gardener)** | Hedge Maze | Hall / Quarters |

* **Swap Rule:** Mask swapping is only possible in **Safe Zones** (areas with no guard vision cone overlap).

### 👁️ Detection & Suspicion System
* **Vision Cones:** Guards have active 2D vision cones.
* **Suspicion Meter:** Fills when entering a vision cone; speed depends on identity match.
* **Capture:** 100% suspicion or no mask results in instant capture.

## 4. Level Design (Zones)

| Zone | Identity | Design Focus |
| :--- | :--- | :--- |
| **Grand Hall** | Noble | Open space, long sightlines |
| **Servant Quarters** | Servant | Tight corridors, blind corners |
| **Hedge Maze** | Gardener | Obstructed vision, multiple paths |

## 5. Visual & Asset Specifications

* **Resolution:** 64x64 px (Tiles & Characters)
* **Filter Mode:** Point (No Compression)
* **Camera:** Fixed top-down with slight movement smoothing.
* **Tilesets:** Kitchen, Storage (Depo 1/2), Carpet, Balcony, Parquet, Ice-tone Walls, Grey Floors, Tiles, Grass (4+ variations each).

## 6. AI Architecture (Finite State Machine)
The AI cycles through the following states:
**Patrol** -> **Suspicion** -> **Investigate** -> **Chase** -> **Search**.