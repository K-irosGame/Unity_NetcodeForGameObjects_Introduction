# Introduction 

> "Le futur du gaming repose sur des mondes persistants et interconnectés où chaque joueur façonne l’expérience."
> — Phil Spencer, CEO de Microsoft Gaming

Ce projet est le fruit de mes recherches sur les jeux multijoueurs et leur architecture réseau. Selon les statistiques de l'industrie du jeu vidéo, le futur est résolument tourné vers le multijoueur (Cf [Unity Report 2025](https://unity.com/fr/resources/gaming-report)). Ce dépôt propose un guide pratique sur **Unity Netcode for GameObjects (NGO)**, une solution réseau puissante pour développer des expériences multijoueurs fluides et performantes.

  
[![Youtube Tutorial](./Intro.png)](https://youtu.be/GBtkBY6gko0)  

Happy Coding ! <br>
---

## 📌 Contenu du guide

### 🔹 Introduction à Unity Netcode : Guide pratique du multijoueur Unity
- Vue d'ensemble 
- Plan de formation

### 🎮 Les types de jeux multijoueurs
- Local Vs online
- Jeux asynchrones

### 🖥️ Le Headless Server
- clarification conceptuel
- Avantages et cas d’utilisation

### 📡 Les packets de données UDP
- Fonctionnement du protocole UDP
- UDP vs TCP
- Gestion et envoi des packets en jeu

### ⏳ Tick Rate et Update Rate
- Explication des cycles de mise à jour
- Impact sur la réactivité du jeu

### ⚡ Comprendre et savoir réduire la latence des jeux multijoueurs
- Détection des sources de latence
- Optimisations et bonnes pratiques

### 🔄 Les techniques de Synchronisation de jeu multijoueur
- Interpolation & extrapolation
- Techniques pour assurer un gameplay fluide

### 🌍 Les topologies réseau
- Architecture client-serveur
- Serveur décentralisé vs centralisé

### 🏗️ La stack Réseau
- Vue d’ensemble de la pile technologique nécessaire
- Comparaison des solutions disponibles

### 🎯 Les solutions Unity pour le Multijoueur
- Netcode for GameObjects (NGO) vs Netcode for Entities (NE)
- Cas d’usage et choix stratégique
- Exploration des autres solutions (Mirror, Photon ...)

### 🛠️ Configuration d'un projet de jeu multijoueur avec NGO
- Initialisation du projet
- Ajout du package Netcode et configuration des objets réseau

### 🔗 Connection des clients en fonction de l'ownership
- Gestion des connexions et désynchronisations
- Attribution des contrôles aux joueurs

### 🏆 Créer une logique de serveur authoritaire
- Implémentation des règles serveur-first
- Avantages et incovénients des RPCs

### 🎭 Créer une logique orientée client
- Approche client-first
- Avantages et incovénients

### 📍 Définir des points de connexion
- Attribution dynamique de position
- Implémentation de mécanique basique

### 🎨 Affecter dynamiquement une couleur aux joueurs
- Synchronisation des attributs visuels
- Attribution et mise à jour des couleurs en temps réel
- Conclusion

---

## 🚀 Objectifs et perspectives
Ce projet représente une étape clé dans l'exploration du multijoueur sous Unity. L'objectif est d'approfondir les connaissances sur **Netcode for GameObjects (NGO)** et de comprendre les meilleures pratiques pour un jeu multijoueur performant.

📌 **Prochaines étapes :** 
- Optimisation des performances réseau
- Ajout d'un matchmaking avancé
- Test sur un serveur cloud dédié
- Explorez le Distributed Authority et le Netcode For Entities.

📢 **Toute contribution ou retour est le bienvenu !**

---

## 📜 Licence
Ce projet est sous licence MIT. Vous êtes libre de l'utiliser et de le modifier à votre convenance.

---

### 📩 Contact
N'hésitez pas à me contacter via **[LinkedIn](https://linkedin.com/in/ton-nom)** ou **[Twitter](https://twitter.com/ton-nom)** pour échanger sur le sujet !

---
