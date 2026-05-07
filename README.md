```
                                                                                                    
   ▒██░                                                                                             
    ░█   ▓▓▒░                                                                                       
      █      ░░█▓             █░░░░░░░▒▒     ░█▒░░░░░░░██      █░░░░░░░░█       ░▓░░░░░░░░          
       █        ░▓▒██░        █       ▒▒     ▒▒         █      █        ░█      ░▓                  
       █        ░▓     ▓█░    █▒▒▒▒▒▒▒▒░     ▒▒         █      █         █       ▒▓▒▒▒▒▒▒▒░         
       █        ░▓ ░██░       █              ▒▒         █      █         █                █░        
      ░█      ░░█▒            █          ░░  ░█▒░░░░░░░██  ░   █░░░░░░░░█░   ░  ░▓░░░░░░░▓█░        
     ▓▒   ░▓▒▒                                                                                      
    ▓░███                                                                                           
   ▒░                                                                                               
```                                                                                              
# PODS Server

PODS is a multiplayer orbital-combat game inspired by the original *Spacewar!* created by Steve Russell in collaboration with Martin Graetz, Wayne Wiitanen, Bob Saunders, Steve Piner, and others at MIT in the early 1960s.

This repository contains the authoritative dedicated server implementation for PODS.

---

# Project Goals

PODS aims to combine:

- orbital mechanics
- physics-driven movement
- chaotic multiplayer gameplay
- emergent strategy
- moddable infrastructure
- replayable simulation systems
- open protocol experimentation

into a fast-paced multiplayer sandbox built around gravity, momentum, and catastrophic mistakes.

The long-term goal is to create a game ecosystem that supports:

- dedicated community servers
- independent clients
- accessibility-focused implementations
- replay and spectator tooling
- protocol experimentation
- modding and total conversions
- community-driven infrastructure

while maintaining a clear distinction between official and unofficial implementations.

---

# What Is This Repository?

This repository contains the authoritative server implementation for PODS.

This is the headless server-side project responsible for authoritative simulation, networking, and game state management.

The official PODS client implementation can be found here:

- [pods-client](https://github.com/eldenbrig-games/pods-client?utm_source=chatgpt.com)

This repository includes:

- simulation systems
- networking
- authoritative game state
- protocol handling
- matchmaking infrastructure
- replay infrastructure
- server-side gameplay logic

The server is intended to act as the canonical simulation layer for official PODS gameplay.

---

# Open Source Philosophy

PODS is released under the GNU Affero General Public License v3.0 (AGPLv3).

Forks, derivative projects, independent clients, protocol experiments, replay systems, and community tooling are encouraged.

However, unofficial projects should avoid implying official endorsement or identity.

For more information, see:

- [FORKING.md](./FORKING.md)

---

# Generative AI Usage

Some assets within this repository may be partially or fully generated with the assistance of generative AI technologies during early-stage ideation, concept development, placeholder creation, workflow acceleration, or prototyping.

Eldenbrig Games strongly prioritizes human creative direction, iteration, modification, and final implementation. Generative AI is used as a development assistance tool — not as a replacement for artists, musicians, writers, or designers.

Where practical, AI-generated placeholder assets may later be replaced with fully original human-created assets during production.

For full details regarding the studio's approach to ethical AI-assisted development, attribution expectations, and asset usage policies, please see:

- https://github.com/eldenbrig-games/.github/blob/main/profile/GENAI.md

---

# Compatibility and Forking

Independent implementations are encouraged to clearly communicate:

- supported protocol versions
- compatibility expectations
- gameplay or protocol divergences
- issue tracker and support locations

This helps reduce confusion for players and contributors while supporting a healthy ecosystem of forks and experimental implementations.

---

# Project Status

PODS is currently in active early development.

Expect:
- breaking changes
- protocol iteration
- unstable APIs
- incomplete systems
- frequent refactors

Everything is subject to change until the protocol and simulation architecture stabilize.

---

# Community Contributions

Contributions, experiments, forks, research projects, accessibility tooling, protocol implementations, replay tooling, and strange ideas are welcome.

If you build something interesting with PODS, I would genuinely love to see it.

---

# License

Source code in this repository is licensed under the AGPLv3 unless otherwise stated.

Branding, logos, artwork, music, sound effects, and other creative assets may be licensed separately.
