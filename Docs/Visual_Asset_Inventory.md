
# 🎨 Visual Style Guide & Asset Inventory

## 1. Visual Identity (Noir Aesthetic)

* **Art Style:** High-contrast 64x64 Pixel Art.
* **Color Philosophy:** Environments use low-saturation cold tones to ensure that "interactive identity elements" (Masks/Loot) are immediately recognizable.
* **Filter Mode:** Point (No Filter)
* **Compression:** None

## 2. Global Color Palette (Hex Codes)

| Element | Hex Code | Purpose |
| --- | --- | --- |
| **Midnight Black** | `#0D1117` | Safe zones, void, UI background |
| **Inky Blue** | `#1B263B` | Floor shadows, dark corridors |
| **Cold Grey** | `#415A77` | Walls, structural elements |
| **Gold Leaf** | `#EEBA2B` | **Artifacts (Loot)**, interactables |
| **Alert Orange** | `#E85D04` | Suspicion bar, guard alerts |

## 3. Sprite Inventory (Characters & Identity)

| Asset Name | Animation States | Priority | Status |
| --- | --- | --- | --- |
| **The Protagonist** | Idle, Walk (4-way) | 🔥🔥🔥 | ⏳ |
| **Identity Masks** | Crimson, Azure, Emerald (Overlay) | 🔥🔥🔥 | ⏳ |
| **Noble Guard** | Idle, Walk, Alert, Capture | 🔥🔥🔥 | ⏳ |
| **Servant Guard** | Idle, Walk, Alert, Capture | 🔥🔥 | ⏳ |
| **Gardener Guard** | Idle, Walk, Alert, Capture | 🔥🔥 | ⏳ |

## 4. Environment Tilemap (64x64 Modular)

Every zone uses a shared logic: **Floor, Wall, Corner, Door, Obstacle.**

### 🔴 The Grand Hall (Noble Zone)

* **Aesthetic:** Luxury, tension, high exposure.
* **Assets:** Velvet carpets, marble floors, golden pillars, chandeliers, heavy curtains.

### 🔵 Servant Quarters (Utility Zone)

* **Aesthetic:** Cramped, gritty, functional.
* **Assets:** Stone tiles, wooden crates, laundry piles, narrow doors.

### 🟢 Hedge Maze (Garden Zone)

* **Aesthetic:** Natural, mysterious, visual occlusion.
* **Assets:** Bush walls, stone statues, gravel paths, nighttime flower blooms.

## 5. UI & Feedback Assets

* **Health:** 3 Heart Icons (Full/Empty/Lost).
* **Active Slot:** Mask frame with class indicators.
* **Detection:** Suspicion gauge (Empty to Alert).
* **VFX:** Light cones, dust particles (Noir feel), mask swap glow.
