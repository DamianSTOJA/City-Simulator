# Aggregate City Simulator

A city-building game focused on aggregate simulation mechanics inspired by early SimCity and Paradox-style event systems. The core gameplay involves managing population, economy, and zones on a grid while responding to events that shape the city’s development. The game emphasizes strategic decision-making over aesthetic freedom.

## Technologies Chosen

### Framework: MonoGame
- Lightweight, cross-platform 2D game framework using C#.
- Ideal for custom, code-driven development with no reliance on drag-and-drop editors.

### Programming Language: C#
- Robust for simulation logic and modular design.
- Aligns well with MonoGame and object-oriented programming for a clean structure.

### Development Environment: Visual Studio Code
- Lightweight and flexible for coding in C#.
- Supports debugging, project management, and easy integration with MonoGame.

## Core Gameplay Loop

### 1. Simulation
- The game runs a turn-based loop (e.g., one month per turn).

#### Player-controlled actions:
- Place zones (residential, commercial, industrial).
- Allocate budgets (infrastructure, social programs, etc.).

#### Simulated systems:
- **Population**: Growth based on housing and job availability.
- **Economy**: Balancing tax revenue, costs, and citizen satisfaction.
- **Demand**: Fluctuates for different zones based on population needs and events.

### 2. Visual Feedback
- The map is a 2D grid:
  - Tiles represent zones (e.g., green for residential, blue for commercial).
  - Basic overlays show aggregate stats like population, demand, and budget.

### 3. Player Decisions
- Players react to changing simulation states:
  - Address unemployment by zoning more industrial areas.
  - Expand infrastructure to support population growth.
  - Balance spending to avoid budget deficits.

### 4. Goals and Outcomes
- The player’s success is measured by:
  - Population happiness.
  - Economic growth.
  - Long-term sustainability (e.g., balancing pollution, budget deficits).

## Ideas for Future Expansion

### 1. Event-Driven Gameplay
- **Dynamic Events**:
  - Introduce challenges or opportunities, forcing players to make strategic decisions.
    - Example: "A major corporation wants to build in your city. Approve it for tax revenue but risk increased traffic."
- **Trade-Offs**:
  - Each event presents a choice with consequences affecting multiple systems.

### 2. Procedural Replayability
- **Randomized Events**:
  - Modular event system to create unique challenges in each playthrough.
- **Emergent Storytelling**:
  - Events chain together to form a narrative unique to each city.

### 3. Advanced Simulation
- Introduce secondary systems like transportation, energy, or education.
- Allow for long-term planning with macro-level policies.

